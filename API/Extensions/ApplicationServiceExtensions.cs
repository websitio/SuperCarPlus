using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.MappedObjects;using API.Datasets;


// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
 public  static class ApplicationServiceExtensions    {
        
  public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
            // services.AddCors();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options => 
           {  options.UseSqlServer(config.GetConnectionString("DefaultConnection"));             
           });
           return services;
  }
            }    }

