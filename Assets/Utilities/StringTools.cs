using Assets.Dto;
using System;

namespace Assets.Utilities
{
    public static class StringTools
    {
        public static string FixedAddress(string address)
        {
            return address.Trim(' ').Trim().Replace(Const.RETURNLINE, Const.EMPTY)
                .Replace(Const.BREACKLINE, Const.SPACE);
        }
        public static string FixedAddress(AddressDto address)
        {
            address.street = address.street.Trim(' ')
                .Trim()
                .Replace(Const.RETURNLINE, Const.EMPTY)
                .Replace(Const.BREACKLINE, Const.SPACE);
            string addressToSearch;
            if (address.street.ToLower().Contains(Const.NAMEZONE)
                || address.Zone.ToLower().Equals(Const.WITHOUTZONE))
            {
                addressToSearch = TernaryAddress(address.street, Const.LIMITWITHZONE);
            }
            else
            {
                addressToSearch = TernaryAddress(address.street, Const.LIMITWITHOUTZONE);
                addressToSearch += Const.SPACECOMMA
                                    + Const.NAMEZONE
                                    + Const.SPACE
                                    + address.Zone;
            }
            if (!address.street.ToLower().Contains(address.township.ToLower()))
            {
                addressToSearch += Const.SPACECOMMA
                                    + address.township;
            }
            if (!address.street.ToLower().Contains(address.department.ToLower()))
            {
                addressToSearch += Const.SPACECOMMA
                                    + address.department;
            }
            return addressToSearch;
        }
        private static string TernaryAddress(string address, int limit)
        {
            return (address.Length >= limit)
                    ? address.Substring(Const.GETFIRST, limit - 1)
                    : address;
        }
        public static string FileManeDelivery(DateTime dateTime, string noRegistro)
        {
            return string.Concat(
                noRegistro,
                Const.GUION,
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                Const.GUION,
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
                    app += Const.SPACE;
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
