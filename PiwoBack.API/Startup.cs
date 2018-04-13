using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PiwoBack.Repository.ApplicationDbContext;
using PiwoBack.Repository.Interfaces;
using PiwoBack.Repository.Repositories;
using PiwoBack.Services.Interfaces;
using PiwoBack.Services.Services;

namespace PiwoBack.API
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
            services.AddDbContext<PiwoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IBeerService, BeerService>();
            services.AddTransient<IBreweryService, BreweryService>();
            services.AddTransient<IBrewingGroupService, BrewingGroupService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddMvc().AddJsonOptions(options => { options.SerializerSettings.Formatting = Formatting.Indented; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
