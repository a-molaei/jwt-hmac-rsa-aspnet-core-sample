using Microsoft.IdentityModel.Tokens;
using JwtRsaHmacSample.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtRsaHmacSample.Api.Services
{
    public interface IJwtHandler
    {
        JWT Create(string userId);
        TokenValidationParameters Parameters { get; }
    }
}
