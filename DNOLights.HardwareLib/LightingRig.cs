using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNOLights.HardwareLib
{
    class LightingRig
    {
        private LightingRig()
        {
            // Instantiate the Headbanger lights, one for each location
            foreach (LightLocationSet location in Enum.GetValues(typeof(LightLocationSet)))
            {
                InitialiseLight(location);
            }
        }
        private void InitialiseLight(LightLocationSet location)
        {
            var light = new Headbanger(LightConfiguration.getAddress(location));
        }
    }
}
