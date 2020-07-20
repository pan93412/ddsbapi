using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

#pragma warning disable CS1591 // 遺漏公用可見類型或成員的 XML 註解
namespace ddsbapi
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
.ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<Startup>();
});
        }
    }
}
