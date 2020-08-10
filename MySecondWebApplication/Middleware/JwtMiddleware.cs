using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MySecondWebApplication.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondWebApplication.Middleware
{
    public class JwtMiddleware
    {
            private readonly RequestDelegate _next;
            private readonly IConfiguration _appSettings;

            public JwtMiddleware(RequestDelegate next, IConfiguration appSettings)  
            {
                _next = next;
                _appSettings = appSettings;
            }

            public async Task Invoke(HttpContext context)
            {
            if (context.Request.Path.ToString() == "/api/login" || context.Request.Path.ToString() == "/api/register" || context.Request.Path.ToString() == "/") {
                await _next(context);
            }
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                JwtSecurityToken res = null;
                res = AuthenticateToken(token);
            if (res != null)
            {
                await _next(context);
            }
            else {
                await context.Response.WriteAsync("invalid token");
            }              
            }

            public JwtSecurityToken AuthenticateToken(string token)
            {
                try
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_appSettings["Jwt:Secret"]);
                    tokenHandler.ValidateToken(token, new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = TimeSpan.Zero
                    }, out SecurityToken validatedToken);

                    var jwtToken = (JwtSecurityToken)validatedToken;
                    return jwtToken;
                }
                catch
                {
                    return null;
                }
            }
        }
}
