using GisRoutes.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisRoutes.Utilities
{
    public class ReadAppSettings
    {
        private readonly IConfiguration configuration;

        public ReadAppSettings(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public AuthentificationSettings GetAuthentificationSettings()
        {
            AuthentificationSettings autSetting = new AuthentificationSettings();
            this.configuration.GetSection(AuthentificationSettings.name).Bind(autSetting);
            return autSetting;
        }

        public UserGisRoutes GetUserGisRoutes()
        {
            UserGisRoutes userGisRoutes = new UserGisRoutes();
            this.configuration.GetSection(UserGisRoutes.name).Bind(userGisRoutes);
            return userGisRoutes;
        } 
    }
}
