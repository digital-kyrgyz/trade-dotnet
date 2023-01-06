using Microsoft.Extensions.Configuration;

namespace Persistence
{
    internal static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configuration = new();
                configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/API"));
                configuration.AddJsonFile("appsettings.json");

                return configuration.GetConnectionString("PostgreSQL");
            }
        }
    }
}