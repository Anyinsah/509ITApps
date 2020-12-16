using HarrisContactWeb.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*
 * COMMENTED BY JOSIAH ANYINSAH-BONZDIE
 * DUPLICATIVE CODE WILL NOT BE RECOMMENTED
 * COMMENTS ONLY ON CODE WRITTEN BY ME
 */
namespace HarrisContactWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * The code below creates a host in which we create a scope using the services.createscope method()
             * This will allow us to call a service provider and assign into a variable for services
             * this gets the required service for a DbContext and initalises (creates the database).
             * A try catch exception is thrown in case of any errors that may be addressed when the program runs.
             */
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {

                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<HarrisDbContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception exception)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(exception, "An error has occured while creating database");

                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
