using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBillingApp.Models;
using MyBillingApp.Entities;
using MyBillingApp.Repositories;
using Microsoft.Extensions.Configuration;

namespace MyBillingApp
{
    public class Startup
    {

        //public static IConfigurationRoot Configuration { get; set; }

        //public Startup()
        //{
        //    var builder = new ConfigurationBuilder()
        //        .AddEnvironmentVariables();

        //    Configuration = builder.Build();
        //}

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<User>();
            services.AddScoped<ClientRepository>();
            //services.AddDbContext<ClientContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BAOffline;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddDbContext<ClientContext>(options => options.UseNpgsql("User ID=lflhldqlnzwljy;Password=60d2757aa494ae20932ee85137d99f8c047ccad3621a6c78fd4fe53b39ca6f50;Host=ec2-54-217-214-201.eu-west-1.compute.amazonaws.com;Port=5432;Database=d7d07hjfdnl04f;Pooling=true;sslmode=Require;Trust Server Certificate=true;Timeout=1000;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
