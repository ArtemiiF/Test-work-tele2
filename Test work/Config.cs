namespace Test_work
{
    public class Config
    {
        public static ConnectionString ConnectionString { get; set; }
        public static APICitizens APICitizens { get; set; }
    }

    public class ConnectionString
    {
        public string DefaultConnection { get; set; } = string.Empty;
    }
    public class APICitizens
    {
        public string DefaultCall { get; set; } = string.Empty;
    }
}
