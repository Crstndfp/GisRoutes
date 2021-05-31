
using Assets.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace Repository.RestFull
{
    public class ClientGisRoutes
    {
        public ClientGisRoutes() { }

        public JObject getGeolocationByAddress(string address)
        {

            try
            {
                var client = new RestClient(
                "https://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer/findAddressCandidates?f=json&maxLocations=2&SingleLine="
                + address)
                {
                    Timeout = -1
                };
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    string resp = response.Content;
                    JObject res = JsonConvert.DeserializeObject<JObject>(resp);
                    JArray categories = (JArray)res[Const.CANDIDATES];
                    return (categories.Count > Const.ZERO) ? res : null;
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
