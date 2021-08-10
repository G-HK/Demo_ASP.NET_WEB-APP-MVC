using HSPXL2.Data;
using HSPXL2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HSPXL2
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
            services.AddControllersWithViews();

            services.AddDbContext<HSContext>(opts =>
            {
                opts.UseSqlServer(Configuration["ConnectionStrings:HsPXL"]);
            });

            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:IdentityConnection"]));


            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<IdentityContext>();

          


            services.Configure<IdentityOptions>(options =>
            {
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+ ";
                options.User.RequireUniqueEmail = true;
                //options.Password.RequireLowercase = true;
                //options.Password.RequireUppercase = true;
                //options.Password.RequireDigit = true;
            });

            services.AddScoped<IStudentRepository,StudentRepository>();
            services.AddScoped<ICursusRepository,CursusRepository>();
            services.AddScoped<IHandBoekRepository,HandBoekRepository>();
            services.AddScoped<IInschrijvingRepository,InschrijvingRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddSession();

            services.ConfigureApplicationCookie(options => options.AccessDeniedPath = "/User/unauthorizedUser");


            services.AddAuthorization(options => {

                //options.AddPolicy("RequireAdmin",
                //    policy => policy.RequireClaim("Admin"));

                //options.AddPolicy("UserAccess", policy =>
                //policy.RequireAssertion(context => context.User.IsInRole("Admin") || context.User.IsInRole("Teacher") ) );
            });

            services.AddRazorPages(opts =>
            {
                //opts.Conventions.AuthorizeFolder("/Admin", "RequireAdministratorRole");
                //opts.Conventions.AllowAnonymousToPage("/Admin/Users");
            });
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
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();

            });

            SeedData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
