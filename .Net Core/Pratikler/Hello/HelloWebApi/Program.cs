using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HelloWebApi
{
    public class Program
    {
        // Uygulamada ilk çalışan yerdir.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // startup sınıfının config dosyası olduğunu bildirir.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
