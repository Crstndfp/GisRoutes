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
        private const string NAMEZONE = "zona";
        private const string WITHOUTZONE = "sz";
        private const string SPACE = " ";
        private const string LATITUDE = "Y";
        private const string LONGITUDE = "X";
        private const int GETFIRST = 0;
        private const int LIMITWITHOUTZONE = 170;
        private const int LIMITWITHZONE = 163;

        private readonly string address;
        private readonly string zone;
        private readonly string depAndMun;

        public AddressTools(
            string addrerss,
            string zone,
            string depAndMun)
        {
            this.address = addrerss;
            this.zone = zone;
            this.depAndMun = depAndMun;
        }

        public string ArmAddressToSeach()
        {
            string addressToSearch;

            if (this.address.ToLower().Contains(NAMEZONE) 
                || this.zone.ToLower().Equals(WITHOUTZONE))
            {
                addressToSearch = TernaryAddress(LIMITWITHZONE);
                return addressToSearch + SPACE + this.depAndMun;
          
            }
            else
            {
                addressToSearch = TernaryAddress(LIMITWITHOUTZONE);
                return addressToSearch 
                        + SPACE 
                        + NAMEZONE 
                        + SPACE 
                        + this.zone 
                        + SPACE 
                        + this.depAndMun;
            }
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
            return clientGisRoutes.getGeolocationByAddress(
                        ArmAddressToSeach());
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
