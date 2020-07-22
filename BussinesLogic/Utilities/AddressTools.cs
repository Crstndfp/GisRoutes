using Models.ModelsDomCemaco;
using Assets.Dto;
using Newtonsoft.Json.Linq;
using Repository.RestFull;

namespace BussinesLogic.Utilities
{
    public class AddressTools
    {
        private const string CANDIDATES = "candidates";
        private const string LOCATION = "location";
        private const string LATITUDE = "y";
        private const string LONGITUDE = "x";
        private const int GETFIRST = 0;

        private readonly string address;

        public AddressTools(
            string addrerss)
        {
            this.address = addrerss;
        }
        private string TernaryAddress(int limit)
        {
            return (this.address.Length >= limit)
                    ? this.address.Substring(GETFIRST, limit - 1)
                    : this.address;
        }
        private JObject RequestGisRoutes()
        {
            ClientGisRoutes clientGisRoutes = new ClientGisRoutes();
            return clientGisRoutes.getGeolocationByAddress(this.address);
        }
        public ShippingDto UpdateCoordinatesShipping(ShippingDto shipping)
        {
            JObject rest = RequestGisRoutes();
            shipping.Latitude = (rest == null) 
                ? shipping.Latitude 
                : (double)rest[CANDIDATES][GETFIRST][LOCATION][LATITUDE];
            shipping.Longitude = rest != null 
                ? (double)rest[CANDIDATES][GETFIRST][LOCATION][LONGITUDE] 
                : shipping.Longitude;
            return shipping;
        }
        public TableShippingDirDto UpdateCoordinatesEnvioDir(TableShippingDirDto tableShippingDirDto)
        {
            JObject rest = RequestGisRoutes();
            tableShippingDirDto.GeoRefY = (rest == null)
                ? tableShippingDirDto.GeoRefY
                : (double)rest[CANDIDATES][GETFIRST][LOCATION][LATITUDE];
            tableShippingDirDto.GeoRefX = rest != null
                ? (double)rest[CANDIDATES][GETFIRST][LOCATION][LONGITUDE]
                : tableShippingDirDto.GeoRefX;
            return tableShippingDirDto;
        }
        public TableEventDto UpdateCoordinatesEvento(TableEventDto tableEventDto)
        {
            JObject rest = RequestGisRoutes();
            tableEventDto.GeoRefY = (rest == null)
                ? tableEventDto.GeoRefY
                : (double)rest[CANDIDATES][GETFIRST][LOCATION][LATITUDE];
            tableEventDto.GeoRefX = rest != null
                ? (double)rest[CANDIDATES][GETFIRST][LOCATION][LONGITUDE]
                : tableEventDto.GeoRefX;
            return tableEventDto;
        }
    }
}
