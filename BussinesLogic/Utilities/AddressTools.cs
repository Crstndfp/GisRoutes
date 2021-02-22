using Models.ModelsDomCemaco;
using Assets.Dto;
using Newtonsoft.Json.Linq;
using Repository.RestFull;
using Assets.Utilities;

namespace BussinesLogic.Utilities
{
    public class AddressTools
    {
        private readonly string address;

        public AddressTools(
            string addrerss)
        {
            this.address = addrerss;
        }
        private JObject RequestGisRoutes()
        {
            ClientGisRoutes clientGisRoutes = new ClientGisRoutes();
            return clientGisRoutes.getGeolocationByAddress(this.address);
        }
        public GeolocationDto UpdateCoordinates()
        {
            GeolocationDto geolocation = new GeolocationDto();
            JObject rest = RequestGisRoutes();
            if (rest == null)
            {
                geolocation.Latitude = Const.ZERO;
                geolocation.Longitude = Const.ZERO;
            }
            else
            {
                geolocation.Latitude =
                    (double)rest[Const.CANDIDATES][Const.GETFIRST][Const.LOCATION][Const.LATITUDE];
                geolocation.Longitude =
                    (double)rest[Const.CANDIDATES][Const.GETFIRST][Const.LOCATION][Const.LONGITUDE];
            }
            return geolocation;
        }
    }
}
