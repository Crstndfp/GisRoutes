using Assets.Dto;
using System;

namespace Assets.Utilities
{
    public static class StringTools
    {
        public static string FixedAddress(string address)
        {
            return address.Trim(' ').Trim().Replace(ConstNames.RETURNLINE, ConstNames.EMPTY)
                .Replace(ConstNames.BREACKLINE, ConstNames.SPACE);
        }
        public static string FixedAddress(AddressDto address)
        {
            address.street = address.street.Trim(' ')
                .Trim()
                .Replace(ConstNames.RETURNLINE, ConstNames.EMPTY)
                .Replace(ConstNames.BREACKLINE, ConstNames.SPACE);
            string addressToSearch;
            if (address.street.ToLower().Contains(ConstNames.NAMEZONE)
                || address.Zone.ToLower().Equals(ConstNames.WITHOUTZONE))
            {
                addressToSearch = TernaryAddress(address.street, ConstNames.LIMITWITHZONE);
            }
            else
            {
                addressToSearch = TernaryAddress(address.street, ConstNames.LIMITWITHOUTZONE);
                addressToSearch += ConstNames.SPACECOMMA
                                    + ConstNames.NAMEZONE
                                    + ConstNames.SPACE
                                    + address.Zone;
            }
            if (!address.street.ToLower().Contains(address.township.ToLower()))
            {
                addressToSearch += ConstNames.SPACECOMMA
                                    + address.township;
            }
            if (!address.street.ToLower().Contains(address.department.ToLower()))
            {
                addressToSearch += ConstNames.SPACECOMMA
                                    + address.department;
            }
            return addressToSearch;
        }
        private static string TernaryAddress(string address, int limit)
        {
            return (address.Length >= limit)
                    ? address.Substring(ConstNames.GETFIRST, limit - 1)
                    : address;
        }
        public static string FileManeDelivery(DateTime dateTime, string noRegistro)
        {
            return string.Concat(
                noRegistro,
                ConstNames.GUION,
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                ConstNames.GUION,
                dateTime.Hour,
                dateTime.Minute,
                dateTime.Second
                );
        }
        public static string AppendDataArray(
            string app,
            string info,
            int start,
            int finish)
        {
            if (start + info.Length < finish)
            {
                app += info;
                for (int cont = start + info.Length;
                    cont < finish;
                    cont++)
                {
                    app += ConstNames.SPACE;
                }
            }
            else if (finish == -1)
            {
                app += info;
            }
            else
            {
                app += info.Substring(0, finish - start);
            }
            return app;
        }
    }
}
