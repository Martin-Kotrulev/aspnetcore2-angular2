using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace App.Services.Security.Extensions
{
    public class CustomBearerOptions : JwtBearerOptions
    {
        public string SecretKey { get; set; }

        public string Issuer { get; set; }
    }
}