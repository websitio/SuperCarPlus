
using API.MappedObjects;
using API.Datasets;
using API.Models.Interfaces;

// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
 public  static class ApplicationServiceExtensions    {
        
  public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
            // services.AddCors();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options => 
           {  options.UseSqlServer(config.GetConnectionString("DefaultConnection"));             
           });
           return services;
  }
            }    }

