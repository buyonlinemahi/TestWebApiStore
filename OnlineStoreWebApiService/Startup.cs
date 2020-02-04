using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using OnlineStore.Core.Data.SQLServer;
using OnlineStoreWebApiService.Mapper;

namespace OnlineStoreWebApiService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        { Configuration = configuration; }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var config = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json")
             .Build();

            services.AddDbContext<OnlineStoreDbContext>(opt =>
            opt.UseSqlServer(config["ConnectionStrings"]));

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => {
                    var resolver = options.SerializerSettings.ContractResolver;
                    if (resolver != null)
                        (resolver as DefaultContractResolver).NamingStrategy = null;
                });

        }

        public void Configure(IApplicationBuilder app)
        {
            // error log implement later
            //app.UseExceptionHandler("/errors/500");
            //// Handles non-success status codes with empty body
            //app.UseStatusCodePagesWithReExecute("/errors/{0}");

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();

        }
    }
}
