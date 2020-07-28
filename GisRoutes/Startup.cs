using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Models.ModelsWms3;
using Models.ModelsDomCemaco;
using BussinesLogic.Authentication;
using Repository.Stream;
using BussinesLogic.ShippingOrder;
using Repository.DomCemaco;
using Repository.Wms3;
using System.ComponentModel.DataAnnotations;

namespace GisRoutes
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // CONFIGURACIÓN DEL SERVICIO DE AUTENTICACIÓN JWT
            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme)
                .RequireAuthenticatedUser()
                .Build();
            });

            var secretKey = Configuration["AuthentificationSettings:SecretKey"];
            var issuer = Configuration["AuthentificationSettings:Issuer"];
            var audience = Configuration["AuthentificationSettings:Audience"];

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(o =>
            {
                o.Audience = audience;
                o.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey))
                };
            });

            services.AddDbContext<DomCemacoContext>(opt => 
            opt.UseSqlServer(Configuration.GetConnectionString("DomContext")));
            services.AddDbContext<WMS3Context>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("Wms3Context")));

            services.AddMvc();
            services.AddMvc()
                .AddNewtonsoftJson();

            //upload controller
            services.AddScoped<AuthService, AuthService>();
            services.AddScoped<UpdateCoordinates, UpdateCoordinates>();
            services.AddScoped<ShippingOrder, ShippingOrder>();
            //upload bussines login
            services.AddScoped<ReadAppSettings, ReadAppSettings>();
            services.AddScoped<ShippingOrderRepository, ShippingOrderRepository>();
            services.AddScoped<PreOrdersRepository, PreOrdersRepository>();
            services.AddScoped<DepartmentRepository, DepartmentRepository>();
            services.AddScoped<FileRepository, FileRepository>(); //validar carga
            services.AddScoped<UpdateCoordinatesRepository, UpdateCoordinatesRepository>();
            services.AddScoped<UpdatePreOrderRepository, UpdatePreOrderRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
