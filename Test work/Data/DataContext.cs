using Microsoft.EntityFrameworkCore;
using Test_work.Models;

namespace Test_work.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public virtual DbSet<Citizen> Citizens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IList<Citizen> citizens = GetCitizens();

            foreach (var item in citizens)
            {
                builder.Entity<Citizen>().HasData(item);
            }
        }

        private List<Citizen> GetCitizens()
        {
            string URL = Config.APICitizens.DefaultCall;
            List<Citizen> list;
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(URL),
                    Method = HttpMethod.Get
                };

                var result = client.SendAsync(request).Result;
                list = result.Content.ReadFromJsonAsync<List<Citizen>>().GetAwaiter().GetResult();

                foreach (var item in list)
                {
                    request = new HttpRequestMessage
                    {
                        RequestUri = new Uri(URL + "/" + item.Id.ToString()),
                        Method = HttpMethod.Get
                    };

                    result = client.SendAsync(request).Result;
                    item.Age = result.Content.ReadFromJsonAsync<Citizen>().GetAwaiter().GetResult().Age;
                }
            }

            return list;
        }
    }
}
