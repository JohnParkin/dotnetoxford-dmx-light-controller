using System;
using System.Collections.Generic;
using System.Text;

namespace DNOLights.HardwareLib
{
    public class LightConfiguration
    {

        private static readonly Dictionary<LightLocationSet, Byte> LightMapping
            = new Dictionary<LightLocationSet, Byte>
            {
                { LightLocationSet.BL, 1 },
                { LightLocationSet.FL, 13 },
                { LightLocationSet.BR, 25 },
                { LightLocationSet.FR, 37 }
            };

        public static byte getAddress(LightLocationSet location)
        {
            return LightMapping[location];
        }
        public static LightLocationSet getLocation(byte address)
        {
            foreach (LightLocationSet location in Enum.GetValues(typeof(LightLocationSet)))
            {
                if (address == getAddress(location))
                {
                    return location;
                }
            }
            return LightLocationSet.BL;
        }

        public static byte getChannel(Headbanger headbanger, HeadBangerCommandSet command)
        {
            var channel = headbanger.address + command - 1;
            return (byte)channel;

        }

    }
}
