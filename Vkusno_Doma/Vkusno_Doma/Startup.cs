using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data;
using Vkusno_Doma.Data.Interfaces;
using Vkusno_Doma.Data.mocks;
using Vkusno_Doma.Data.Models;
using Vkusno_Doma.Data.Repository;

namespace Vkusno_Doma
{
    public class Startup
    {
        private IConfigurationRoot _configurationString;
        public Startup(IWebHostEnvironment webHost)
        {
            _configurationString = new ConfigurationBuilder().SetBasePath(webHost.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_configurationString.GetConnectionString("DefaultConnection")));
            services.AddTransient <IAllFoods, FoodRepository>();
            services.AddTransient<IFoodsCategory, CategoryRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => FoodCart.GetCart(sp));
            services.AddRazorPages();
            services.AddMemoryCache();
            services.AddSession();
            services.AddMvc(option => option.EnableEndpointRouting = false);
          

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();//
            app.UseSession();

          
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
            
            
        }
    }
}
