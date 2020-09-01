using System.Linq;
using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Pet.Application.Controllers;
using Pet.Application.Extensions;
using Pet.Core.AutoMapper;
using Pet.Core.Data;
using Pet.Core.Dto.AppSettings;
using Pet.Core.Localization;
using Pet.Data;
using Pet.Services.interfaces;
using Pet.Services.Services;

namespace Pet.Admin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var _local = new LocalizationModel();
            Configuration.GetSection(_local.Localizations).Bind(_local);
            Lanuages = _local;
        }
        public IConfiguration Configuration { get; }
        public LocalizationModel Lanuages { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(IProfile));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped<IUserService, UserService>();
            services.AddDbContext<EfDbContext>(options =>
            {
                options
                .UseSqlServer(Configuration.GetConnectionString("default"));
            }); 
           
            services.AddCustomLocalization(Lanuages);
            services.AddControllersWithViews()
                .AddBaseControllerAsService()
            .AddMvcLocalization()
            .AddDataAnnotationsLocalization(options =>
            {
                options.DataAnnotationLocalizerProvider = (type, factory) =>
                    factory.Create(typeof(PetLocalization));
            }).AddNewtonsoftJson();
            //Ìæ»»Ä¬ÈÏ Controller ¼¤»îÆ÷
            services.Replace(ServiceDescriptor.Transient<IControllerActivator, BaseControllerActivator>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCustomRequestLocalization(Lanuages);

            app.UseRequestLocalization();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints
                .MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints
                .MapAreaControllerRoute(
                    name: "areas", "areas",
                    pattern:
                    "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
