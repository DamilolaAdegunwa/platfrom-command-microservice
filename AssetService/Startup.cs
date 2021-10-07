using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
using AssetService.Data;
using Microsoft.AspNetCore.Http;
using System.Threading;
using AssetService.Models;
using System.IO;

namespace AssetService
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
            services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("InMem"));
            services.AddScoped<IAssetRepo, AssetRepo>();
            services.AddControllers();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AssetService", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AssetService v1"));
            //}

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                //endpoints.
                //endpoints.MapGet("/test",(ctx) => Task.FromResult("app is running"));
                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

                //endpoints.MapGet("/hello/{name:alpha}", async context =>
                //{
                //    var name = context.Request.RouteValues["name"];
                //    await context.Response.WriteAsJsonAsync(new { message = $"Hello {name}!" }, cancellationTokenSource.Token);
                //});
                var assets = new List<Asset>() { 
                    new Asset { Id = 1, Name = "prince of persia game", Cost = "$9.99", Publisher = "Persia Game Studio"},
                    new Asset { Id = 2, Name = "Mortal Kombat game", Cost = "$2.99", Publisher  = "MK Studio"},
                    new Asset { Id = 3, Name = "Warrior Within game", Cost = "$3.99", Publisher  = "MK Studio"},
                    new Asset { Id = 4, Name = "Dark Side game", Cost  = "$1.99", Publisher = "Ninja Gaming Studio"}
                };

                endpoints.MapGet("/", async context => {
                    await context.Response.WriteAsJsonAsync(assets);
                    //await context.Response.WriteAsync(Newtonsoft.Json.JsonConvert.SerializeObject(assets));
                });

                endpoints.MapPost("/", async context => {
                    using(var ms = new MemoryStream())
                    {
                        
                        context.Response.Body.CopyTo(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        var x = Newtonsoft.Json.JsonConvert.SerializeObject(ms);
                        StreamReader reader = new StreamReader(ms);
                        var line = "";
                        var allLines = "";
                        while((line = reader.ReadLine()) != null)
                        {
                            allLines += line;
                        }
                        await context.Response.WriteAsJsonAsync(assets);
                        var assetObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Asset>(allLines);
                    }
                });
                endpoints.MapControllers();
            });
            PrepDb.PrePopulation(app);
        }
    }
}
