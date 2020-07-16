using GisRoutes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisRoutes.Utilities
{
    public static class StringClean
    {
        private const string NAMEZONE = "zona";
        private const string WITHOUTZONE = "sz";
        private const string SPACECOMMA = ", ";
        private const string SPACE = " ";
        private const int LIMITWITHOUTZONE = 146;
        private const int LIMITWITHZONE = 139;
        private const int GETFIRST = 0;
        public static string FixedAddress(string address)
        {
            return address.Trim(' ').Trim().Replace("\r", "")
                .Replace("\n", " ");
        }
        public static string FixedAddress(Address address)
        {
            address.street = address.street.Trim(' ')
                .Trim()
                .Replace("\r", "")
                .Replace("\n", " ");
            string addressToSearch;
            if (address.street.ToLower().Contains(NAMEZONE)
                || address.Zone.ToLower().Equals(WITHOUTZONE))
            {
                addressToSearch = TernaryAddress(address.street, LIMITWITHZONE);
            }
            else
            {
                addressToSearch = TernaryAddress(address.street, LIMITWITHOUTZONE);
                addressToSearch += SPACECOMMA
                                    + NAMEZONE
                                    + SPACE
                                    + address.Zone;
            }
            if (!address.street.ToLower().Contains(address.township.ToLower()))
            {
                addressToSearch += SPACECOMMA
                                    + address.township;
            }
            if (!address.street.ToLower().Contains(address.department.ToLower()))
            {
                addressToSearch += SPACECOMMA
                                    + address.department;
            }
            return addressToSearch;
        }
        private static string TernaryAddress(string address, int limit)
        {
            return (address.Length >= limit)
                    ? address.Substring(GETFIRST, limit - 1)
                    : address;
        }
    }
}
