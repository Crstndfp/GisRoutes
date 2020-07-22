﻿using Assets.Dto;
using Microsoft.Extensions.Configuration;

namespace BussinesLogic.Authentication
{
    public class ReadAppSettings
    {
        private readonly IConfiguration configuration;

        public ReadAppSettings(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public AuthentificationSettingsDto GetAuthentificationSettings()
        {
            AuthentificationSettingsDto autSetting = new AuthentificationSettingsDto();
            this.configuration.GetSection(AuthentificationSettingsDto.name).Bind(autSetting);
            return autSetting;
        }

        public UserGisRoutesDto GetUserGisRoutes()
        {
            UserGisRoutesDto userGisRoutes = new UserGisRoutesDto();
            this.configuration.GetSection(UserGisRoutesDto.name).Bind(userGisRoutes);
            return userGisRoutes;
        } 
    }
}
