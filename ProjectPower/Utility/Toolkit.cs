

using System;

namespace ProjectPower.Utility
{
    public static class Toolkit
    {
       public static decimal Ceiling(decimal value, decimal significance)
        {
            if ((value % significance) != 0)
            {
                return ((int)(value / significance) * significance) + significance;
            }

            return Convert.ToDecimal(value);
        }

        public static decimal RoundToNearestIncrement(decimal value)
        {
            var divided = value / 2.5m;
            Console.WriteLine(divided);
            Math.Ceiling(divided);
            var newNumber = divided * 2.5m;
            return newNumber;
        }


    }
}
