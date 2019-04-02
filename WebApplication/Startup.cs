using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WebApplication.DtoModels;
using AutoMapper;
using WebApplication.Data;
using SubscriptionServiceReference;
using System.ServiceModel;
using UserServiceReference;

namespace WebApplication
{
    public class Startup
    {
        public static IConfiguration Configuration { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IUserService, UserServiceClient>();
            services.AddSingleton<ISubscriptionService, SubscriptionServiceClient>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddSingleton(new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); }).CreateMapper());

            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.Add(.AddDbContext<DBContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("DBContext")));services.AddScoped<IDocumentIntegration>(provider => {

            //services
            //    .AddScoped<ISubscriptionService>(provider => 
            //    {
            //        var subscriptionServiceClient = new SubscriptionServiceClient();

            //        subscriptionServiceClient.Endpoint.Address = new EndpointAddress(Configuration["EndpointAddresses: SubscriptionServiceClient"]);

            //        return subscriptionServiceClient;
            //    })
            //    .AddScoped<IUserService>(provider =>
            //    {
            //        var userServiceClient = new UserServiceClient();

            //        userServiceClient.Endpoint.Address = new EndpointAddress(Configuration["EndpointAddresses: UserServiceClient"]);

            //        return userServiceClient;
            //    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(appBuilder => 
                {
                    appBuilder.Run(async context =>
                   {
                       context.Response.StatusCode = 500;
                       await context.Response.WriteAsync("Unexpected error occured!");
                   });
                });

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            //app.UseMvc(routes => routes.MapRoute(name: "default",
            //                                     template: "{controller=Users}/{action=Index}/{id?}"));

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserServiceReference.User, UserDto>().ForMember(x => x.Subscriptions, y => y.MapFrom(z => z.Subscriptions));
                cfg.CreateMap<UserDto, UserServiceReference.User>();
                cfg.CreateMap<SubscriptionServiceReference.Subscription, SubscriptionDto>();
                cfg.CreateMap<SubscriptionDto, SubscriptionServiceReference.Subscription>();
            });

            app.UseMvcWithDefaultRoute();
        }
    }
}