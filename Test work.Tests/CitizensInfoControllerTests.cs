using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.EntityFrameworkCore;
using Test_work.Controllers;
using Test_work.Data;
using Test_work.Models;
using Xunit;

namespace Test_work.Tests
{
    public class CitizensInfoControllerTests
    {

        Mock<DataContext> dbContextMock;
        CitizensInfoController controller;

        public CitizensInfoControllerTests()
        {
            //Arrange
            dbContextMock = new Mock<DataContext>();
            IList<Citizen> citizens = new List<Citizen>(){
                new Citizen()
                {
                    Id = "daoshfdsji",
                    Name = "Olga Pavlova",
                    Sex = "female",
                    Age = 27
                },
                new Citizen()
                {
                    Id = "daossdffsd",
                    Name = "Valerii Zhmih",
                    Sex = "male",
                    Age = 54
                },
                new Citizen()
                {
                    Id = "asdgfdrji",
                    Name = "Ira Lalova",
                    Sex = "female",
                    Age = 30
                },
                new Citizen()
                {
                    Id = "pdfnkljsdf",
                    Name = "Denis Petrov",
                    Sex = "male",
                    Age = 27
                }
            };

            dbContextMock.Setup(x => x.Citizens).ReturnsDbSet(citizens);
            controller = new CitizensInfoController(dbContextMock.Object);
        }

        [Fact]
        public async void GetAllCitizen_ReturnOkResult()
        {
            //Arrange         

            //Act
            var result = await controller.GetAll(null,null);

            //Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }
        [Fact]
        public async void GetAllCitizen_ReturnBadResult()
        {
            //Arrange         
            GetCitizenQueryObject queryObject = new GetCitizenQueryObject() { Sex = "female", MinAge = 19, MaxAge = 15 };
            //Act
            var result = await controller.GetAll(queryObject, null);

            //Assert
            Assert.IsType<BadRequestResult>(result.Result);
        }
        [Fact]
        public async void GetAllCitizen_ReturnNotFoundResult()
        {
            //Arrange         
            GetCitizenQueryObject queryObject = new GetCitizenQueryObject() { Sex = "female", MinAge = 104, MaxAge = 150 };
            //Act
            var result = await controller.GetAll(queryObject, null);

            //Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }



        [Fact]
        public async void GetSingleCitizen_ReturnOkresult()
        {
            //Arrange         
            var id = dbContextMock.Object.Citizens.FirstOrDefault().Id;

            //Act
            var result = await controller.GetSingle(id);

            //Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public async void GetSingleCitizen_ReturnNotFoundresult()
        {
            //Arrange         
            var id = string.Empty;

            //Act
            var result = await controller.GetSingle(id);

            //Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        
       
    }
}
