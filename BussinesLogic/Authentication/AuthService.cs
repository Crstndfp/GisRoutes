using Assets.Dto;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BussinesLogic.Authentication
{
    public class AuthService
    {
        private readonly ReadAppSettings readAppSettings;
        public AuthService(ReadAppSettings readAppSettings)
        {
            this.readAppSettings = readAppSettings;
        }
        public bool ValidateLogin(UserDataDto userData)
        {
            UserGisRoutesDto userGisRoutes = this.readAppSettings.GetUserGisRoutes();
            return (userData.UserName.Equals(userGisRoutes.UserName) 
                && userData.Password.Equals(userGisRoutes.Password));
        }

        public string GenerateToke(DateTime date, string user, TimeSpan validDate)
        {
            AuthentificationSettingsDto authentificationSettings =
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
