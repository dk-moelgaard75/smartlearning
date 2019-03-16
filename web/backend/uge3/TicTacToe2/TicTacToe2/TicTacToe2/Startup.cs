using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TicTacToe2.Extensions;
namespace TicTacToe2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //Tillader directory browsing
            //services.AddDirectoryBrowser();
            services.AddSingleton<Services.IUserServices, Services.UserServices>();
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            RouteBuilder routeBuilder = new RouteBuilder(app);
            routeBuilder.MapGet("CreateUser", context =>
            {
                var firstName = context.Request.Query["firstname"];
                var lastName = context.Request.Query["lastname"];
                var passWord = context.Request.Query["password"];
                var email = context.Request.Query["email"];
                var userService = context.RequestServices.GetService<Services.IUserServices>();
                userService.RegisterUser(new Models.UserModel { FirstName = firstName, LastName = lastName, Email = email, Password = passWord });
                return context.Response.WriteAsync($"User {firstName} {lastName} has been succesfully created - thru routing");

            });
            routeBuilder.MapGet("DoTest", context =>
            {
                var fn = context.Request.Query["fn"];
                var ln = context.Request.Query["ln"];
                return context.Response.WriteAsync($"DoTest called with {fn} {ln}");
            }
            );
            
            var newUserRoutes = routeBuilder.Build();
            app.UseRouter(newUserRoutes);
            var options = new RewriteOptions();
            options.AddRewrite("NewUser", "UserRegistration/Index", false);
            app.UseRewriter(options);
            app.UseCommunicationMiddleware();
            //Laver en directorylistning
            //app.UseDirectoryBrowser();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                      name: "default",
                      template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseStatusCodePages("text/plain", "HTTP Error - Status code: {0}");
        }
    }
}
