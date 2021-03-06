using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using ShoppingCart.Api.Extensions;
using ShoppingCart.Business;
using ShoppingCart.Business.Helpers;
using ShoppingCart.Business.Interfaces;
using ShoppingCart.Common.Model;
using ShoppingCart.Common.Models;
using ShoppingCart.DataAccess.Repository;

namespace ShoppingCart.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore

            );

            services.AddControllers();
            services.AddSingleton<IRepository<CategoryModel>, CategoryRepository>();
            services.AddSingleton<IProductRepository<ProductModel>, ProductRepository>();
            services.AddSingleton<IProductManager, ProductManager>();
            services.AddSingleton<IRepository<CustomerModel>, CustomerRepository>();
            services.AddCors();

            // configure strongly typed settings object
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            // configure DI for application services
            services.AddScoped<IUserManager, UserManager>();

            services.AddAutoMapper(typeof(CategoryRepository));
            services.AddAutoMapper(typeof(ProductRepository));
            services.AddAutoMapper(typeof(CustomerRepository));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger logger)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // global cors policy
            app.UseCors(builder => builder.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());

            // Middleware
            app.ConfigureExceptionHandler(logger);
            app.UseMiddleware<JwtMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
