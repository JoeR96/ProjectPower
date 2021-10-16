

using System;

namespace ProjectPower.Utility
{
    public static class Toolkit
    {
        public static decimal RoundToNearestIncrement(decimal value)
        {
            var divided = value / 2.5m;
            Math.Ceiling(divided);
            var newNumber = divided * 2.5m;
            return newNumber;
        }
    }
}
