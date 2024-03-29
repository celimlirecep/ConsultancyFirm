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
            //�dentity i�in Database i�lemi
            services.AddDbContext<ApplicationContext>(options => options.UseSqlite(Configuration.GetConnectionString("SQLiteConnection")));
            services.AddDbContext<ConsultantFirmContext>(options => options.UseSqlite(Configuration.GetConnectionString("SQLiteConnection")));
           

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            //Paralo vs i�in gereklilikler
            services.Configure<IdentityOptions>(options =>
            {
                //pasword
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = true;
                //Lockout
                options.Lockout.MaxFailedAccessAttempts = 3;//3 kere yanl�� girebilsin
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);//10 dk beklesin hatal� giri�te
                options.Lockout.AllowedForNewUsers = true;
                //user
                options.User.RequireUniqueEmail = true;
                //Sign in
                options.SignIn.RequireConfirmedEmail = true;
            });
            //Cookie  i�lemleri
            services.ConfigureApplicationCookie(options =>
            {

                options.LoginPath = "/login";
                options.LogoutPath = "/logout";
                options.AccessDeniedPath = "/accesdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);//yar�m saat cookiyi sakla
                options.SlidingExpiration = true;//her requestte i�lemi 0 la
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,//sadece authentice olmu� pencerede a��k kals�n
                    Name = "ConsultancyFirm.Security.Cookie",
                    SameSite = SameSiteMode.Strict// a��lan pencere ile s�n�rl�
                };
            });
            //mail i�lemleri
            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
                Configuration["EmailSender:Host"],
                Configuration.GetValue<int>("EmailSender:Port"),//string harici kullan�c�lak t�r belirtme �ekli
                Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                Configuration["EmailSender:UserName"],
                Configuration["EmailSender:Password"]
                ));

            services.AddScoped<IHeadingService, HeadingManager>();
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IHomeSliderService, HomeSliderManager>();
            services.AddScoped<IMemberService_Service, MemberServiceManager>();
            services.AddScoped<IMessageService, MessageManager>();



            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();//Identity
            app.UseRouting();
            //app.UseCookiePolicy();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapControllerRoute(
                name: "appointment",
                pattern: "mypage/message/{IsGetPage?}",
                defaults: new { controller = "Message", action = "Index" }
                );
               
             
                endpoints.MapControllerRoute(
                name: "appointment",
                pattern: "mypage/history",
                defaults: new { controller = "MemberService", action = "MemberAppointment" }
                );

                endpoints.MapControllerRoute(
                 name: "appointment",
                 pattern: "mypage/appointment/{username?}",
                 defaults: new { controller = "MemberService", action = "Index" }
                 );


                endpoints.MapControllerRoute(
                  name: "categories",
                  pattern: "healtylife/{category?}",
                  defaults: new { controller = "HealtyLife", action = "List" }
                  );
                endpoints.MapControllerRoute(
                      name: "loginpage",
                      pattern: "mypage/{username?}",
                      defaults: new { controller = "Account", action = "MemberPage" }
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
