using System;
using System.Collections.Generic;
using System.Text;


namespace SRPExample
{
    public static class CountriesFormatter
    {
        public static string FormatForConsole(Country country)
        {
            return string.Format("{0}, Capital: {1} - Region: {2}", country.Name, country.Capital, country.Region);
        }
    }
}
