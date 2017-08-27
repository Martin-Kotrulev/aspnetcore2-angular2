using App.Config;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Services.Security.Extensions
{
    public static class SecurityExtensions
    {
        public static IServiceCollection AddSecurity(this IServiceCollection services, IConfiguration config)
        {
            services.AddAuthentication(opt => {
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt => { new CustomBearerOptions() {
                Audience = config["JWTSettings:Audience"],
                Authority = config["JWTSettings:Authority"],
                ClaimsIssuer = config["JWTSettings:Issuer"],
                SecretKey = config["JWTSettings:SecretKey"],
                RequireHttpsMetadata = false
            };});

            services.AddAuthorization(auth => {
                // auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                //     .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                //     .RequireAuthenticatedUser()
                //     .Build());
                // auth.AddPolicy("Admin", p => p.RequireRole("Admin"));
            });

            return services;
        }
    }
}