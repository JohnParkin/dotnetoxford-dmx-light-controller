using DNOLights.HardwareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNOLights.HardwareLib
{
    public class Headbanger
    {

        public byte getValuefromCommand(HeadBangerCommandSet command)
        {
            switch (command)
            {
                case HeadBangerCommandSet.pan:
                    {
                        return this.pan;
                    }
                case HeadBangerCommandSet.tilt:
                    {
                        return this.tilt;
                    }
                case HeadBangerCommandSet.fade:
                    {
                        return this.fade;
                    }
                case HeadBangerCommandSet.red:
                    {
                        return this.red;
                    }
                case HeadBangerCommandSet.green:
                    {
                        return this.green;
                    }
                case HeadBangerCommandSet.blue:
                    {
                        return this.blue;
                    }
                case HeadBangerCommandSet.white:
                    {
                        return this.white;
                    }
            }

            return 0;
        }
        public void setValuefromCommand(HeadBangerCommandSet command, byte val)
        {
            switch (command)
            {
                case HeadBangerCommandSet.pan:
                    {
                        this.pan = val;
                        break;
                    }
                case HeadBangerCommandSet.tilt:
                    {
                        this.tilt = val;
                        break;
                    }
                case HeadBangerCommandSet.fade:
                    {
                        this.fade = val;
                        break;
                    }
                case HeadBangerCommandSet.red:
                    {
                        this.red = val;
                        break;
                    }
                case HeadBangerCommandSet.green:
                    {
                        this.green = val;
                        break;
                    }
                case HeadBangerCommandSet.blue:
                    {
                        this.blue = val;
                        break;
                    }
                case HeadBangerCommandSet.white:
                    {
                        this.white = val;
                        break;
                    }
            }
        }

        public Headbanger(byte address)
        {
            this.address = address;
            location = LightConfiguration.getLocation(address);

            // initialise all four lights 
            switch (location)
            {
                case LightLocationSet.BL:
                    {
                        this.pan = 0;
                        this.pan_fine = 0;
                        this.tilt = 120;
                        this.tilt_fine = 0;
                        this.fade = 100;
                        this.red = 100;
                        this.green = 0;
                        this.blue = 0;
                        this.white = 0;
                        this.color_macro = 0;
                        this.strobe = 0;
                        this.sound = 0;

                        break;
                    }
                case LightLocationSet.FL:
                    {
                        this.pan = 120;
                        this.pan_fine = 0;
                        this.tilt = 80;
                        this.tilt_fine = 0;
                        this.fade = 100;
                        this.red = 50;
                        this.green = 0;
                        this.blue = 0;
                        this.white = 0;
                        this.color_macro = 0;
                        this.strobe = 0;
                        this.sound = 0;

                        break;
                    }
                case LightLocationSet.FR:
                    {
                        this.pan = 120;
                        this.pan_fine = 0;
                        this.tilt = 80;
                        this.tilt_fine = 0;
                        this.fade = 100;
                        this.red = 50;
                        this.green = 0;
                        this.blue = 0;
                        this.white = 0;
                        this.color_macro = 0;
                        this.strobe = 0;
                        this.sound = 0;

                        break;
                    }
                case LightLocationSet.BR:
                    {
                        this.pan = 0;
                        this.pan_fine = 0;
                        this.tilt = 120;
                        this.tilt_fine = 0;
                        this.fade = 100;
                        this.red = 0;
                        this.green = 100;
                        this.blue = 0;
                        this.white = 0;
                        this.color_macro = 0;
                        this.strobe = 0;
                        this.sound = 0;

                        break;
                    }

            }
        }

        LightLocationSet location = 0;
        public byte address { get; }
        public byte pan { get; set; } = 0;
        public byte pan_fine = 0;
        public byte tilt { get; set; } = 0;
        public byte tilt_fine = 0;
        public byte fade { get; set; } = 0;
        public byte red { get; set; } = 0;
        public byte green { get; set; } = 0;
        public byte blue { get; set; } = 0;
        public byte white { get; set; } = 0;

        public byte color_macro = 0;
        public byte strobe = 0;
        public byte sound = 0;
    }

}

  
