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
using System.ComponentModel.DataAnnotations;
using BussinesLogic.Utilities;
using Microsoft.OpenApi.Models;
using System.IO;
using System;
using System.Reflection;
using Repository.DomCemaco;
using Repository.Wms3;

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
            opt.UseSqlServer(Configuration.GetConnectionString("DomContext"))
            .EnableSensitiveDataLogging());
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
            services.AddScoped<TransportRepository, TransportRepository>();


            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Shipping service API",
                    Description = "Returns all home orders that have been scheduled on different platforms",
                    Contact = new OpenApiContact
                    {
                        Name = "Cristian Flores",
                        Email = "cristian.flores@cemaco.com"
                    }
                });

                // To Enable authorization using Swagger (JWT)  
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n " +
                                    "Enter 'Bearer' [space] and then your token in the text input below." +
                                    "\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

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
