using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoftUniClone.Web.Filters;
using System.Diagnostics;
using SoftUniClone.Data;
using AspNet.Security.OAuth.GitHub;
using SoftUniClone.Web.Areas.Identity.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using SoftUniClone.Models;
using Microsoft.Extensions.FileProviders;

namespace SoftUniClone.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<User>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            
            services.AddAuthentication()
                .AddGoogle(options => {

                    options.ClientId = "303515638916-cns6mv23v2q29qsb0eevtvm0k98nlkvs.apps.googleusercontent.com";
                    options.ClientSecret = "7EJAVz4lCFGvCxMzmqk-SkSi";

                });

            
            services.AddAuthentication()
                   .AddGitHub(options =>
                   {
                       options.ClientId = "5b19bf9587ff7b455a62";
                       options.ClientSecret = "7b2c7157e8c21067021cb18e95ee316bf196f5a7";
                   });


            services.AddSingleton<IEmailSender, EmailSender>();
            
            services.Configure<IdentityOptions>(options =>
            {
                options.Password = new PasswordOptions()
                {
                    RequiredLength = 3,
                    RequireUppercase = false,
                    RequireDigit = false,
                    RequiredUniqueChars = 0,
                    RequireLowercase = false,
                    RequireNonAlphanumeric = false
                };

                options.Lockout.AllowedForNewUsers = true;

                options.Lockout.MaxFailedAccessAttempts = 3;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);

            });

            services.Configure<StaticFileOptions>(config => {
                config.FileProvider = new PhysicalFileProvider("C:\\Users\\Asus\\SoftUni\\9.C# Web\\C# Web MVC Frameworks ASP.NET\\12.Architecture Part 1\\SoftUniClone\\SoftUniClone.Web\\wwwroot\\");
            });

            services.AddScoped<Stopwatch>();

            services.AddMvc(options => {
                options.Filters.Add<LogExecution>();
            });

            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
