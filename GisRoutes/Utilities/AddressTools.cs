using GisRoutes.Dto;
using GisRoutes.Models;
using GisRoutes.RestFull;
using GisRoutes.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisRoutes.Utilities
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
        public Shipping UpdateCoordinatesShipping(Shipping shipping)
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
        public TblEnvioDir UpdateCoordinatesEnvioDir(TblEnvioDir tblEnvioDir)
        {
            JObject rest = RequestGisRoutes();
            tblEnvioDir.GeoRefY = (rest == null)
                ? tblEnvioDir.GeoRefY
                : (double)rest[CANDIDATES][GETFIRST][LOCATION][LATITUDE];
            tblEnvioDir.GeoRefX = rest != null
                ? (double)rest[CANDIDATES][GETFIRST][LOCATION][LONGITUDE]
                : tblEnvioDir.GeoRefX;
            return tblEnvioDir;
        }
        public TblEvento UpdateCoordinatesEvento(TblEvento tblEvento)
        {
            JObject rest = RequestGisRoutes();
            tblEvento.GeoRefY = (rest == null)
                ? tblEvento.GeoRefY
                : (double)rest[CANDIDATES][GETFIRST][LOCATION][LATITUDE];
            tblEvento.GeoRefX = rest != null
                ? (double)rest[CANDIDATES][GETFIRST][LOCATION][LONGITUDE]
                : tblEvento.GeoRefX;
            return tblEvento;
        }
    }
}
