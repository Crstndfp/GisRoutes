using GisRoutes.Dto;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GisRoutes.Services
{
    public class AuthService
    {
        public bool ValidateLogin(UserData userData)
        {
            return (userData.UserName.Equals("GisRoutes") 
                && userData.Password.Equals("mikom234sss"));
        }

        public string GenerateToke(DateTime date, string user, TimeSpan validDate)
        {
            DateTime expire = date.Add(validDate);

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(
                    JwtRegisteredClaimNames.Iat,
                    new DateTimeOffset(date).ToUniversalTime().ToUnixTimeSeconds().ToString(),
                    ClaimValueTypes.Integer64
                    ),
                new Claim("roles", "Cliente"),
                new Claim("roles","Administrador")
            };

            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes("OLAh6Yh5KwNFvOqglmke")),
                SecurityAlgorithms.HmacSha256Signature
                );

            var jwt = new JwtSecurityToken(
                issuer: "cemaco",
                audience: "gisroutes",
                claims: claims,
                notBefore: date,
                expires: expire,
                signingCredentials: signingCredentials
                );

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return encodedJwt;
        }
    }
}
