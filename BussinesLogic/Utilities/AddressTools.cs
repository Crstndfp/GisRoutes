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
        public GeolocationDto UpdateCoordinates(GeolocationDto geolocation)
        {
            JObject rest = RequestGisRoutes();
            geolocation.Latitude = (rest == null)
                ? geolocation.Latitude
                : (double)rest[Const.CANDIDATES][Const.GETFIRST][Const.LOCATION][Const.LATITUDE];
            geolocation.Longitude = rest != null
                ? (double)rest[Const.CANDIDATES][Const.GETFIRST][Const.LOCATION][Const.LONGITUDE]
                : geolocation.Longitude;
            return geolocation;
        }
    }
}
