using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PortalAPI.Models;
using PortalAPI.Repository;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Authentication.JwtBearer;
//using TicketingAPI.Middleware;
using PortalAPI.Models.HR;
using PortalAPI.Models.InformationTechnology;
using PostAPI.Repository.Residence;
using PortalAPI.Repository.Residence;


namespace PortalAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );
            services.Configure<FormOptions>(o =>  // currently all set to max, configure it to your needs!
            {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = long.MaxValue; // <-- !!! long.MaxValue
                o.MultipartBoundaryLengthLimit = int.MaxValue;
                o.MultipartHeadersCountLimit = int.MaxValue;
                o.MultipartHeadersLengthLimit = int.MaxValue;
            });

            services.AddHttpContextAccessor();
            services.AddDbContext<AISContext>(item => item.UseSqlServer(Configuration.GetConnectionString("BlogDBConnection")));
            services.AddDbContext<HRContext>(item => item.UseSqlServer(Configuration.GetConnectionString("HRDBConnection")));
            services.AddDbContext<InformationTechnologyContext>(item => item.UseSqlServer(Configuration.GetConnectionString("InformationTechnologyDBConnection")));
            services.AddDbContext<ResidenceContext>(item => item.UseSqlServer(Configuration.GetConnectionString("ResidenceDBConnection")));

            services.AddScoped<Items_Interface, Items_Repository>(); 
            services.AddScoped<Account_Interface, Account_Repository>();
            services.AddScoped<Employee_Interface, Employee_Repository>();

            services.AddScoped<Projects_Interface, Projects_Repository>();
            services.AddScoped<Buildings_Interface, Buildings_Repository>();
            services.AddScoped<Units_Interface, Units_Repository>();
            services.AddScoped<Requests_Interface, Requests_Repository>();

            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
                options.AutomaticAuthentication = false;
                options.MaxRequestBodySize = null;
            });
            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });

            services.AddSwaggerGen(config =>
            {
                var titleBase = "HAH API - ";
                var Contact = new OpenApiContact()
                {
                    Name = "Information Technology Department",
                    Email = "Ahmed.shafeek@hassanallam.com"
                };

                config.SwaggerDoc("Catalog", new OpenApiInfo { Version = "Catalog", Title = titleBase + " Catalog", Contact = Contact });
                config.SwaggerDoc("Portal", new OpenApiInfo { Version = "Portal", Title = titleBase + " Portal", Contact = Contact });

                config.SwaggerDoc("ARBim", new OpenApiInfo { Version = "ARBim", Title = titleBase + " ARBim", Contact = Contact });

                config.SwaggerDoc("Residence", new OpenApiInfo { Version = "Residence", Title = titleBase + " Residence", Contact = Contact });

                config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                config.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,

                        },
                        new List<string>()
                      }
                    });
            });

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            // Configure the JWT Authentication Service
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            })
            .AddJwtBearer("JwtBearer", jwtOptions =>
            {
                jwtOptions.TokenValidationParameters = new TokenValidationParameters()
                {
                    // The SigningKey is defined in the TokenController class
                    IssuerSigningKey = Account_Repository.SIGNING_KEY,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
                jwtOptions.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "True");
                        }
                        return Task.CompletedTask;
                    }
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //var googleCredential = env.ContentRootPath;
            //var filePath = Configuration.GetSection("GoogleFirebase")["Auth.json"];
            //googleCredential = Path.Combine(googleCredential, filePath);
            //var credential = GoogleCredential.FromFile(googleCredential);
            //FirebaseApp.Create(new AppOptions()
            //{
            //    Credential = credential
            //});
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {

                c.SwaggerEndpoint("/swagger/Portal/swagger.json", "Portal");
                c.SwaggerEndpoint("/swagger/Catalog/swagger.json", "Catalog");
                c.SwaggerEndpoint("/swagger/ARBim/swagger.json", "ARBim");

                c.SwaggerEndpoint("/swagger/Residence/swagger.json", "Residence");
                c.RoutePrefix = string.Empty;
            });
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            
            //app.UseRouting();
            app.UseAuthentication();  // Must be before app.UseMvc
            app.UseAuthorization();
            app.UseMiddleware<ExpiredTokenMiddleware>();
            //app.UseMiddleware<LoggingMiddleware>();
            //app.UseMvc(routes => {
            //    routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseMvc();
            //app.UseEndpoints(endpoints => {
            //    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            //});


        }
    }
}
