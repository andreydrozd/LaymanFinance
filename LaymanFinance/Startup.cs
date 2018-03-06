using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using LaymanFinance.Models;
using SendGrid;
using Braintree;

namespace LaymanFinance
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
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

            services.AddMvc(options =>
            {
                options.Filters.Add(new Microsoft.AspNetCore.Mvc.Authorization.AuthorizeFilter(policy));
            });

            services.AddAntiforgery();
            services.AddSession();

            //This will read the appsettings.json into an object which I can use throughout my app:
            services.Configure<Models.ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            services.AddOptions();

            services.AddDbContext<AndreyTestContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions.MigrationsAssembly(this.GetType().Assembly.FullName))
            );

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AndreyTestContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<SendGrid.SendGridClient>((x) =>
            {
                return new SendGridClient(Configuration["sendgrid"]);
            });

            services.AddTransient<BraintreeGateway>((x) =>
            {
                return new BraintreeGateway(
                    Configuration["braintree.environment"], 
                    Configuration["braintree.merchantid"], 
                    Configuration["braintree.publickey"], 
                    Configuration["braintree.privatekey"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // This is where middleware is called and configured.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AndreyTestContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            DbInitializer.Initialize(context);
        }
    }
}
