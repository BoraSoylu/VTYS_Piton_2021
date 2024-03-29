using Business.Abstract;
using Business.Conrete;
using DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI
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
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder => builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                .AllowAnyOrigin());
            });

            services.AddScoped<ICitizenAuthDAL, CitizenAuthenticationDAL>();
            services.AddScoped<ICitizenService, CitizenManager>();
            services.AddScoped<ICitizenDAL, CitizenDAL>();
            services.AddScoped<IAuthService, AuthenticationManager>();
            services.AddScoped<IStaffService, StaffManager>();
            services.AddScoped<IStaffDAL, StaffDAL>();
            services.AddScoped<IComplaintDAL, ComplaintDAL>();
            services.AddScoped<IComplaintService, ComplaintManager>();
            services.AddScoped<IComplaintTypeDAL, ComplaintTypeDAL>();
            services.AddScoped<IComplaintTypeService, ComplaintTypeManager>();
            services.AddScoped<IAuthorizationService, AuthorizationManager>();
            services.AddScoped<IAuthorizationDAL, AuthorizationDAL>();
            services.AddScoped<Business.Utilities.TokenHandler>();
            services.AddScoped<IStaffAuthenticationDAL, StaffAuthenticationDAL>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddHttpContextAccessor();


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
