using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductAPI.Data;
using ProductAPI.Repositories.Implementation;
using ProductAPI.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Extensions
{
    /// <summary>
    /// Configure ServiceExtensions
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Configure Cors
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin() 
                    .AllowAnyMethod()                   
                    .AllowAnyHeader());                 
            });
        }

        /// <summary>
        /// Configure SqlServerContext
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SqlServerConnection")));
        }

        /// <summary>
        /// Configure Repositories
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
