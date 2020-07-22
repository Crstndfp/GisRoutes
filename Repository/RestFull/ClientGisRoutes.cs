
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace Repository.RestFull
{
    public class ClientGisRoutes
    {
        private const int CODE_OK = 200;
        public ClientGisRoutes() { }

        public JObject getGeolocationByAddress(string address)
        {

            try
            {
                var client = new RestClient(
                "https://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer/findAddressCandidates?f=json&singleLine="
                + address
                + "&location=%7B%22x%22%3A-10075930.263089431%2C%22y%22%3A1647271.998164099%2C%22spatialReference%22%3A%7B%22wkid%22%3A102100%2C%22latestWkid%22%3A3857%7D%7D&maxLocations=2")
                {
                    Timeout = -1
                };
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    string resp = response.Content;
                    JObject res = JsonConvert.DeserializeObject<JObject>(resp);
                    JArray categories = (JArray)res["candidates"];
                    return (categories.Count > 0) ? res : null;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
