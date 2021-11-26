using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
namespace WebApp
{
    public class Startup
    {
        [Obsolete]
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment;
        readonly string AllowOrigin = "AllowOrigin";
        [Obsolete]
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            Configuration = configuration;
            hostingEnvironment = environment;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddCors(c =>
            {
                c.AddPolicy(AllowOrigin, options =>
                {
                    options.WithOrigins("https://localhost:44301", "https://sandbox.vnpayment.vn")
                    .SetIsOriginAllowed(isOriginAllowed:_=>true)
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });
            services.AddControllersWithViews();
            
            //services.AddSingleton<IBackgroundJob, BackgroundJob>();
            var keysDirectoryName = "Keys";
            var keysDirectoryPath = Path.Combine(hostingEnvironment.ContentRootPath, keysDirectoryName);
            if (!Directory.Exists(keysDirectoryPath))
            {
                Directory.CreateDirectory(keysDirectoryPath);
            }
            services.AddDataProtection()
              .PersistKeysToFileSystem(new DirectoryInfo(keysDirectoryPath))
              .SetApplicationName("CustomCookieAuthentication");
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(op =>
            {
                op.Cookie.Name = "AuthCookie";
                op.Cookie.SameSite = SameSiteMode.Lax;
                op.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                op.Cookie.Path = "/";
                op.LoginPath = new PathString("/users/auth/signin");
                op.LogoutPath = new PathString("/users/auth/signout");
                op.ExpireTimeSpan = TimeSpan.FromDays(300);
                op.AccessDeniedPath = new PathString("/users/auth/denied");
                op.Cookie.IsEssential = true;

            });
            services.AddAntiforgery(options =>
            {
                options.Cookie.Name = "AntiforgeryCookie";
                options.Cookie.Domain = "";
                options.Cookie.Path = "/";
                options.Cookie.Expiration = TimeSpan.FromDays(300);
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.Cookie.IsEssential = true;
            });
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(            IApplicationBuilder app,    IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
          
            app.UseStaticFiles();  
            app.UseRouting();
            app.UseCors(AllowOrigin);       
            app.UseAuthentication();                  
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(name: "areas3", areaName: "Admin", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
                endpoints.MapAreaControllerRoute(name: "areas2", areaName: "Doctor", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
                endpoints.MapAreaControllerRoute(name: "areas1", areaName: "Patient", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
                endpoints.MapAreaControllerRoute(name: "areas4", areaName: "Users", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
                endpoints.MapAreaControllerRoute(name: "areas5", areaName: "Specialist_Doctor", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
            });
          
        }
    }
}
