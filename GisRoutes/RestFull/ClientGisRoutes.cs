using GisRoutes.Dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisRoutes.RestFull
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
                + "&outFields=Match_addr,Addr_type")
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
