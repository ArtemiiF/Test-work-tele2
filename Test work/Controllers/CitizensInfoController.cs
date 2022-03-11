using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Test_work.Data;
using Test_work.Models;

namespace Test_work.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizensInfoController : ControllerBase
    {
        DataContext dbContext;

        public CitizensInfoController(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("GetAll/")]
        public async Task<ActionResult<List<Citizen>>> GetAll([FromQuery] GetCitizenQueryObject getCitizenQueryObject, [FromQuery] Paging paging)
        {
            List<Citizen> citizens = dbContext.Citizens.ToList();

            if (getCitizenQueryObject is not null)
            {
                if (getCitizenQueryObject.Sex is not null && getCitizenQueryObject.Sex != "")
                {
                    switch (getCitizenQueryObject.Sex.ToLower())
                    {
                        case "male":
                            citizens = (from c in citizens
                                        where c.Sex.ToLower() == "male"
                                        orderby c.Age
                                        select c).ToList();
                            break;

                        case "female":
                            citizens = (from c in citizens
                                        where c.Sex.ToLower() == "female"
                                        orderby c.Age
                                        select c).ToList();
                            break;
                        default:
                            return BadRequest("No such sex");
                    }

                }

                if (!(getCitizenQueryObject.MinAge is null && getCitizenQueryObject.MaxAge is null))
                {
                    try
                    {
                        byte minAge = Convert.ToByte(getCitizenQueryObject.MinAge);
                        byte maxAge = Convert.ToByte(getCitizenQueryObject.MaxAge);

                        if (minAge > maxAge || maxAge == 0)
                            return BadRequest();

                        citizens = (from c in citizens
                                    where (c.Age >= minAge && c.Age < maxAge)
                                    orderby c.Age
                                    select c).ToList();
                    }
                    catch (Exception)
                    {
                        return BadRequest();
                    }
                }
            }


            PagingInfo pagingInfo;
            if (paging is not null)
            {
                if (paging.PageNumber <= 0 || paging.PageSize <= 0)
                    return BadRequest("PageNumber or PageSize are less than zero");
                
                pagingInfo = new PagingInfo(paging, dbContext.Citizens.Count() / (paging.PageSize));
                
            }
            else
                pagingInfo = new PagingInfo(new Paging() { PageNumber = 1, PageSize = 6 }, dbContext.Citizens.Count() / (6));

            try
            {
                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagingInfo));
            }
            catch 
            { }

            if (citizens.Count == 0)
            {
                return NotFound();
            }


            return Ok(citizens.Skip((pagingInfo.PageNumber - 1) * pagingInfo.PageSize).Take(pagingInfo.PageSize));
        }

        [HttpGet("GetSingle/{id}")]
        public async Task<ActionResult<Citizen>> GetSingle(string id)
        {
            var Citizen = dbContext.Citizens.FirstOrDefault(c => c.Id == id.ToLower());
            if (Citizen != null)
                return Ok(Citizen);

            return NotFound();
        }
    }

    public class GetCitizenQueryObject
    {
        public string Sex { get; set; } = string.Empty;
        public byte? MinAge { get; set; }
        public byte? MaxAge { get; set; }
    }

    public class Paging
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 6;
    }

    public class PagingInfo : Paging
    {
        private int pageCount = 0;

        public int PageCount => pageCount;
        public PagingInfo(Paging p, int pageCount)
        {
            PageNumber = p.PageNumber;
            PageSize = p.PageSize;
            this.pageCount = pageCount;
        }

    }
}
