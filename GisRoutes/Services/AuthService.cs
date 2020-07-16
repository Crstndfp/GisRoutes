using GisRoutes.Dto;
using GisRoutes.Utilities;
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
        private readonly ReadAppSettings readAppSettings;
        public AuthService(ReadAppSettings readAppSettings)
        {
            this.readAppSettings = readAppSettings;
        }
        public bool ValidateLogin(UserData userData)
        {
            UserGisRoutes userGisRoutes = this.readAppSettings.GetUserGisRoutes();
            return (userData.UserName.Equals(userGisRoutes.UserName) 
                && userData.Password.Equals(userGisRoutes.Password));
        }

        public string GenerateToke(DateTime date, string user, TimeSpan validDate)
        {
            AuthentificationSettings authentificationSettings =
                this.readAppSettings.GetAuthentificationSettings();

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
                //new Claim("roles", "Cliente"),
                //new Claim("roles","Administrador")
            };

            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(
                    authentificationSettings.SecretKey)),
                SecurityAlgorithms.HmacSha256Signature
                );

            var jwt = new JwtSecurityToken(
                issuer: authentificationSettings.Issuer,
                audience: authentificationSettings.Audience,
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
