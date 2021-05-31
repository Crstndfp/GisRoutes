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
            try
            {
                string aux = "";

                address.street = address.street.Trim(' ')
                    .Trim()
                    .Replace(Const.RETURNLINE, Const.EMPTY)
                    .Replace(Const.BREACKLINE, Const.SPACE);

                if (!address.street.ToLower().Contains(Const.NAMEZONE)
                    && !address.Zone.ToLower().Equals(Const.WITHOUTZONE))
                {
                    aux += Const.SPACECOMMA
                                        + Const.NAMEZONE
                                        + Const.SPACE
                                        + address.Zone; ;
                }

                if (!address.street.ToLower().Contains(address.township.ToLower()))
                {
                    aux += Const.SPACECOMMA
                                        + address.township;
                }
                if (!address.street.ToLower().Contains(address.department.ToLower()))
                {
                    aux += Const.SPACECOMMA
                                        + address.department;
                }

                aux += " GUATEMALA";

                return TernaryAddress(address.street, aux.Length) + aux;
            } catch (ArgumentNullException)
            {
                throw new Exception();
            }
        }
        private static string TernaryAddress(string address, int complement)
        {
            return (address.Length + complement >= Const.LIMIT)
                    ? address.Substring(Const.GETFIRST, Const.LIMIT - complement - 1)
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
