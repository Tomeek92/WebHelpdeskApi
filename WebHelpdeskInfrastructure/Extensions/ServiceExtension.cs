using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace WebHelpdeskInfrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WebHelpdeskApiDbContext>(
             options => options.UseSqlServer(configuration.GetConnectionString("WebHelpdeskMVC")));
        }
    }
}
