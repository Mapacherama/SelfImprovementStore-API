using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Self_help_Webstore_GraphQL_API.Self_help_Webstore_GraphQL_API.Web;

namespace Mapacherama.SelfhelpStoreAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}