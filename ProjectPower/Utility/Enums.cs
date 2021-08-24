using System.ComponentModel;

namespace ProjectPower.Utility
{
    public class Enums
    {
        public enum Tier
        {
            [Description("1")]
            One = 1,
            [Description("2")]
            Two = 2,
            [Description("3A")]
            ThreeA = 3,
            [Description("3B")]
            ThreeB = 4,
            [Description("4A")]
            FourA = 5,
            [Description("4B")]
            FourB = 6,
        }

        public enum TargetGroup
        {
            Legs,
            Chest,
            Back,
            Shoulders
        }
    }
}
