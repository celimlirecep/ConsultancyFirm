using ColsultancyFirm.DAL.Abstract;
using ColsultancyFirm.DAL.Concreate.EFCore;
using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.BL.Concreate;
using ConsultancyFirm.UI.EmailServices;
using ConsultancyFirm.UI.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            //Ýdentity için Database iþlemi
            services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=ConsultancyFirmDB"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            //Paralo vs için gereklilikler
            services.Configure<IdentityOptions>(options => {
                //pasword
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                 options.Password.RequireLowercase = true;
                //Lockout
                options.Lockout.MaxFailedAccessAttempts = 3;//3 kere yanlýþ girebilsin
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);//10 dk beklesin hatalý giriþte
                options.Lockout.AllowedForNewUsers = true;
                //user
                options.User.RequireUniqueEmail = true;
                //Sign in
                options.SignIn.RequireConfirmedEmail = true;
            });
            //Cookie  iþlemleri
            services.ConfigureApplicationCookie(options => {

                options.LoginPath = "/login";
                options.LogoutPath = "/logout";
                options.AccessDeniedPath = "/accesdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);//yarým saat cookiyi sakla
                options.SlidingExpiration = true;//her requestte iþlemi 0 la
           
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,//sadece authentice olmuþ pencerede açýk kalsýn
                    Name="ConsultancyFirm.Security.Cookie",
                    SameSite=SameSiteMode.Strict// açýlan pencere ile sýnýrlý
                    

                };
            });
            //mail iþlemleri
            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
                Configuration["EmailSender:Host"],
                Configuration.GetValue<int>("EmailSender:Port"),//string harici kullanýcýlak tür belirtme þekli
                Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                Configuration["EmailSender:UserName"],
                Configuration["EmailSender:Password"]
                ));

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
            services.AddScoped<IMemberService_Service, MemberServiceManager>();
            services.AddScoped<IMemberServiceRepository, EFCoreMemberServiceRepository>();

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
            app.UseAuthentication();//Identity
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "appointment",
                pattern: "mypage/appointment/{username?}",
                defaults: new { controller = "MemberService", action = "MemberAppointment" }
                );

                endpoints.MapControllerRoute(
                 name: "appointment",
                 pattern: "mypage/{username?}/{categoryId?}/{authorId?}",
                 defaults: new { controller = "MemberService", action = "Index" }
                 );

              
                endpoints.MapControllerRoute(
                  name: "categories",
                  pattern: "healtylife/{category?}",
                  defaults: new { controller = "HealtyLife", action = "List" }
                  );
              

                endpoints.MapControllerRoute(
                  name: "loginpage",
                  pattern: "login",
                  defaults: new { controller = "Account", action = "Login" }
                  );

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
