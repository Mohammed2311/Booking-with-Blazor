using Blazor.Api.Helper;
using Busniss.Interfaces;
using Busniss.mapper;
using Busniss.Repositry;
using DataLayer.DB;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Api
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

            services.AddControllers()
            .AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Blazor.Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please Bearer and then token in the field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                   {
                     new OpenApiSecurityScheme
                     {
                       Reference = new OpenApiReference
                       {
                         Type = ReferenceType.SecurityScheme,
                         Id = "Bearer"
                       }
                      },
                      new string[] { }
                    }
                });
            });

            services.AddScoped<IHotelRep,HotelRepositry>();
            services.AddScoped<IRoomImgRep, RoomImageRep>();
            services.AddScoped<IRoomDetailsRep, RoomDetailsRep>();
            //services.AddIdentity <IdentityUser,IdentityRole>().
            //    AddEntityFrameworkStores<MoContext>().AddDefaultTokenProviders();

            //services.AddCors(o => o.AddPolicy("HiddenVilla", builder =>
            //{
            //    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            //}));
            services.AddCors();

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;
            }).AddEntityFrameworkStores<MoContext>()
              .AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>(TokenOptions.DefaultProvider);

            var appSettingsSec = Configuration.GetSection("ApiSettings");
          
            services.Configure<ApiSettings>(appSettingsSec);
            var appSettings = appSettingsSec.Get<ApiSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);

            services.AddAuthentication(opt=>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
             .AddJwtBearer(op =>
             {
                 op.RequireHttpsMetadata = false;
                 op.SaveToken = true;
                 op.TokenValidationParameters = new TokenValidationParameters()
                 {
                     ValidateIssuerSigningKey = true,
                     IssuerSigningKey = new SymmetricSecurityKey(key),
                     ValidateAudience = true,
                     ValidateIssuer = true, 
                     ValidAudience = appSettings.ValidAudience ,
                     ValidIssuer = appSettings.ValidIssuer,
                     ClockSkew = TimeSpan.Zero

                 };

             }
                
                );

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
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor.Api v1"));
            }

            app.UseHttpsRedirection();
            

            app.UseCors(options => options
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());
            app.UseRouting();
            //app.UseCors(opt =>
            //{
            //    opt.AllowAnyMethod();
            //    opt.AllowAnyOrigin();

            //}
            //    );
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
