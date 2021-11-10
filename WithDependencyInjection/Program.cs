using Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace WithDependencyInjection
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Host");
            await CreateHost().RunAsync();
            Console.WriteLine("Stopping Host");
        }

        private static IHost CreateHost()
        {
            // The following creates a host object for the console app to run
            // It sets up services which is a dependency injection container or an IoC container
            // ConfigureServices can use a lambda instead of an explicit function.
            return Host.CreateDefaultBuilder() 
                .ConfigureServices(RegisterServices)
                .Build();
        }

        private static void RegisterServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapperProfile));
        }
    }
}
