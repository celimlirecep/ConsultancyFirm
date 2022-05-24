using ColsultancyFirm.DAL.Abstract;
using ColsultancyFirm.DAL.Concreate.EFCore;
using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.BL.Concreate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI
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
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<IHeadingService, HeadingManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IHeadingRepository, EFCoreHeadingRepository>();
            services.AddScoped<IAuthorRepository, EFCoreAuthorRepository>();
            services.AddScoped<ICategoryRepository, EFCoreCategoryRepository>();
            services.AddScoped<IMemberService, MemberManager>();
            services.AddScoped<IMemberRepository, EFCoreMemberRepository>();
            services.AddScoped<IHomeSliderService, HomeSliderManager>();
            services.AddScoped<IHomeSliderRepository, EFCoreHomeSliderRespository>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDB.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(

                //  name: "authors",
                //  pattern: "members/{username?}",
                //  defaults: new { controller = "Member", action = "MemberPage" }

                //  );
                endpoints.MapControllerRoute(

                    name: "authors",
                    pattern: "authors/{heading?}",
                    defaults: new { controller = "Authors", action = "List" }

                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=HomePage}/{id?}");
            });
        }
    }
}
