using BlazorServer.Data;
using Busniss.Interfaces;
using DataLayer.DB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Busniss.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Busniss.Repositry;
using BlazorServer.Services.IServices;
using BlazorServer.Services.Service;

namespace BlazorServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddScoped<IHotelRep,HotelRepositry>();
            services.AddScoped<IHotelAmenity, HotelAmenityRep>();
            services.AddScoped<IFileUploader, FileUploader>();
            services.AddScoped<IRoomImgRep, RoomImageRep>();
            services.AddHttpContextAccessor();
            services.AddDbContextPool<MoContext>(option =>
           option.UseSqlServer(Configuration.GetConnectionString("MooConnection")));

            services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
