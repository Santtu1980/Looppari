using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looppari
{
    public static class Calculate
    {
        public static decimal CountPercentage(int percentageFrom, int percentageTo)
        {
            if (percentageTo == 0) return 0;
            try
            {
                return Math.Round(((decimal)percentageFrom / (decimal)percentageTo) * 100, 1);
            }
            catch
            {
                return 0;
            }
        }

        public static string FormatNumber(int input)
        {
            try
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                return input.ToString("#,0", nfi);
            }
            catch
            {
                return input.ToString();
            }
        }

        public static string FormatResultAndPercentage(int value, int compare)
        {
            return $"{FormatNumber(value)} kpl. {Calculate.CountPercentage(value, compare)}%";
        }
    }
}
