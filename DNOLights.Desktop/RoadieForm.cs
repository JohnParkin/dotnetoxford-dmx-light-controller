using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNOLights.HardwareLib;
using static DNOLights.Desktop.DMXCommands;

namespace DNOLights.Desktop
{
    public partial class RoadieForm : Form
    {
        Headbanger hb_BackLeft = new Headbanger((byte)LightLocationSet.BL);
        Headbanger hb_FrontLeft = new Headbanger((byte)LightLocationSet.FL);
        Headbanger hb_BackRight = new Headbanger((byte)LightLocationSet.BR);
        Headbanger hb_FrontRight = new Headbanger((byte)LightLocationSet.FR);

        public void SetChannelValue(Control ctrl,
                                    //ref byte val,
                                    Headbanger light,
                                    HeadBangerCommandSet command,
                                    Func<byte, byte> incDecCallback)
        {
            byte _channel = LightConfiguration.getChannel(light, command);
            var val = light.getValuefromCommand(command);
            val = incDecCallback(val);
            OpenDMX.setDmxValue( _channel , val);
            light.setValuefromCommand(command , val);
            ctrl.Text = val.ToString();
        }

        public byte inc(byte parameter)
        {
            var x = parameter + 10;
            if (x > 255) { x = 255; };
            if (x < 0) { x = 0; };
            return (byte)x;
        }
        public byte dec(byte parameter)
        {
            var x = parameter - 10;
            if (x > 255) { x = 255; };
            if (x < 0) { x = 0; };
            return (byte)x;
        }

        public RoadieForm()
        {
            InitializeComponent();

            //BackLeft
            BL_Pan.Text     = hb_BackLeft.pan.ToString();
            BL_Tilt.Text    = hb_BackLeft.tilt.ToString();
            BL_Fade.Text    = hb_BackLeft.fade.ToString();
            BL_Red.Text     = hb_BackLeft.red.ToString();
            BL_Green.Text   = hb_BackLeft.green.ToString();
            BL_Blue.Text    = hb_BackLeft.blue.ToString();
            BL_White.Text   = hb_BackLeft.white.ToString();

            //FrontLeft
            FL_Pan.Text     = hb_FrontLeft.pan.ToString();
            FL_Tilt.Text    = hb_FrontLeft.tilt.ToString();
            FL_Fade.Text    = hb_FrontLeft.fade.ToString();
            FL_Red.Text     = hb_FrontLeft.red.ToString();
            FL_Blue.Text    = hb_FrontLeft.blue.ToString();
            FL_Green.Text   = hb_FrontLeft.green.ToString();
            FL_White.Text   = hb_FrontLeft.white.ToString();

            //FrontRight
            FR_Pan.Text     = hb_FrontRight.pan.ToString();
            FR_Tilt.Text    = hb_FrontRight.tilt.ToString();
            FR_Fade.Text    = hb_FrontRight.fade.ToString();
            FR_Red.Text     = hb_FrontRight.red.ToString();
            FR_Blue.Text    = hb_FrontRight.blue.ToString();
            FR_Green.Text   = hb_FrontRight.green.ToString();
            FR_White.Text   = hb_FrontRight.white.ToString();

            //BackRight
            BR_Pan.Text     = hb_BackRight.pan.ToString();
            BR_Tilt.Text    = hb_BackRight.tilt.ToString();
            BR_Fade.Text    = hb_BackRight.fade.ToString();
            BR_Red.Text     = hb_BackRight.red.ToString();
            BR_Blue.Text    = hb_BackRight.blue.ToString();
            BR_Green.Text   = hb_BackRight.green.ToString();
            BR_White.Text   = hb_BackRight.white.ToString();
        }
        private void Connect_DMX(object sender, EventArgs e)
        {
            try
            {
                OpenDMX.start();                                            //find and connect to device (first found if multiple)
                if ( OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)       //update status
                {
                    DMXStatusLabel.Text = "No DMX Device";
                    DMXStatusLabel.BackColor = Color.DarkOrange;
                }
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    DMXStatusLabel.Text = "DMX Connected";
                    DMXStatusLabel.BackColor = Color.Green;
                }
                else
                {
                    DMXStatusLabel.Text = "DMX Error";
                    DMXStatusLabel.BackColor = Color.DarkOrange;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                DMXStatusLabel.Text = "USB Error";
                DMXStatusLabel.BackColor = Color.Red;
            }

            //for (byte channel = byte.MinValue; channel < byte.MaxValue; channel++ )
            //{
            //    OpenDMX.setDmxValue(channel, 0);
            //}

            foreach (HeadBangerCommandSet command in Enum.GetValues(typeof(HeadBangerCommandSet)))
            {
                byte value;
                
                //backleft
                value = hb_BackLeft.getValuefromCommand(command);
                OpenDMX.setDmxValue(hb_BackLeft.address + (byte)command, value);
                Console.WriteLine(command.ToString(), value);

                //front left
                value = hb_FrontLeft.getValuefromCommand(command);
                OpenDMX.setDmxValue(hb_FrontLeft.address + (byte)command, value);
                Console.WriteLine(command.ToString(), value);

                //back right
                value = hb_BackRight.getValuefromCommand(command);
                OpenDMX.setDmxValue(hb_BackRight.address + (byte)command, value);
                Console.WriteLine(command.ToString(), value);

                //front right
                value = hb_FrontLeft.getValuefromCommand(command);
                OpenDMX.setDmxValue(hb_FrontLeft.address + (byte)command, value);
                Console.WriteLine(command.ToString(), value);
            }
        }
        
        private void first_scene_click(object sender, EventArgs e)
        {

            if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
            {
                DMXStatusLabel.Text = "No DMX Device";
                DMXStatusLabel.BackColor = Color.DarkOrange;
            }
            else if (OpenDMX.status == FT_STATUS.FT_OK)
            {
                // set it all to zero
                for (int x=1; x < 513;x++)
                {
                    OpenDMX.setDmxValue(x, 0);
                }
            }

        }

        private void FR_Blue_TextChanged(object sender, EventArgs e)
        {

        }

        private void panright_Click(object sender, EventArgs e) 
            => SetChannelValue( BL_Pan,
                                hb_BackLeft,
                                HeadBangerCommandSet.pan, 
                                x => inc(x));

        private void panleft_Click(object sender, EventArgs e) 
            => SetChannelValue( BL_Pan,
                                hb_BackLeft,
                                HeadBangerCommandSet.pan, 
                                x => dec(x));

        private void BL_Red_Up_Click(object sender, EventArgs e)
            => SetChannelValue( BL_Red,
                                hb_BackLeft,
                                HeadBangerCommandSet.red,
                                x => inc(x));

        private void BL_Red_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( BL_Red,
                                hb_BackLeft,
                                HeadBangerCommandSet.red,
                                x => dec(x));
        private void BL_Pan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
            => SetChannelValue( BL_Tilt,
                                hb_BackLeft,
                                HeadBangerCommandSet.tilt,
                                x => dec(x));

        private void BL_Tilt_Up_Click(object sender, EventArgs e)
            => SetChannelValue(BL_Tilt,
                                hb_BackLeft,
                                HeadBangerCommandSet.tilt,
                                x => inc(x));

        private void BL_Fade_Up_Click(object sender, EventArgs e) 
            => SetChannelValue( BL_Fade, 
                                hb_BackLeft,
                                HeadBangerCommandSet.fade, 
                                x => inc(x));

        private void BL_Fade_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue(BL_Fade,
                                hb_BackLeft,
                                HeadBangerCommandSet.fade,
                                x => dec(x));


        private void button7_Click(object sender, EventArgs e)
            => SetChannelValue( BL_Green,
                                hb_BackLeft,
                                HeadBangerCommandSet.green,
                                x => inc(x));

        private void BL_G_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue(BL_Green,
                                hb_BackLeft,
                                HeadBangerCommandSet.green,
                                x => dec(x));

        private void button9_Click(object sender, EventArgs e)
            => SetChannelValue( BL_Blue,
                                hb_BackLeft,
                                HeadBangerCommandSet.blue,
                                x => inc(x));

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
            => SetChannelValue( BL_Blue,
                                hb_BackLeft,
                                HeadBangerCommandSet.blue,
                                x => dec(x));
        
        private void BL_White_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( BL_White,
                                hb_BackLeft,
                                HeadBangerCommandSet.white,
                                x => dec(x));
        
        private void BL_White_Up_Click(object sender, EventArgs e)
            => SetChannelValue(BL_White,
                                hb_BackLeft,
                                HeadBangerCommandSet.white,
                                x => inc(x));
        
        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void FL_Pan_Right_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Pan,
                                hb_FrontLeft,
                                HeadBangerCommandSet.pan,
                                x => inc(x));

        private void FL_Pan_Left_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Pan,
                                hb_FrontLeft,
                                HeadBangerCommandSet.pan,
                                x => dec(x));

        private void FL_Tilt_Fwd_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Tilt,
                                hb_FrontLeft,
                                HeadBangerCommandSet.tilt,
                                x => dec(x));

        private void FL_Tilt_Bck_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Tilt,
                                hb_FrontLeft,
                                HeadBangerCommandSet.tilt,
                                x => inc(x));

        private void FL_Fade_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Fade,
                                hb_FrontLeft,
                                HeadBangerCommandSet.fade,
                                x => dec(x));

        private void FL_Fade_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Fade,
                                hb_FrontLeft,
                                HeadBangerCommandSet.fade,
                                x => inc(x));

        private void FL_Red_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Red,
                                hb_FrontLeft,
                                HeadBangerCommandSet.red,
                                x => dec(x));

        private void FL_Red_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Red,
                                hb_FrontLeft,
                                HeadBangerCommandSet.red,
                                x => inc(x));

        private void FL_Green_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Green,
                                hb_FrontLeft,
                                HeadBangerCommandSet.green,
                                x => dec(x));

        private void FL_Green_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue(FL_Green,
                                hb_FrontLeft,
                                HeadBangerCommandSet.green,
                                x => inc(x));

        private void FL_Blue_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Blue,
                                hb_FrontLeft,
                                HeadBangerCommandSet.blue,
                                x => dec(x));

        private void FL_Blue_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FL_Blue,
                                hb_FrontLeft,
                                HeadBangerCommandSet.blue,
                                x => inc(x));

        private void FL_White_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FL_White,
                                hb_BackLeft,
                                HeadBangerCommandSet.white,
                                x => dec(x));

        private void FL_White_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FL_White,
                                hb_BackLeft,
                                HeadBangerCommandSet.white,
                                x => inc(x));

        private void BR_Pan_Left_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Pan,
                                hb_BackRight,
                                HeadBangerCommandSet.pan,
                                x => dec(x));

        private void BR_Pan_Right_Click(object sender, EventArgs e)
            => SetChannelValue(BR_Pan,
                                hb_BackRight,
                                HeadBangerCommandSet.pan,
                                x => inc(x));

        private void BR_Tilt_Fwd_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Tilt,
                                hb_BackRight,
                                HeadBangerCommandSet.tilt,
                                x => dec(x));

        private void BR_Tilt_Bck_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Tilt,
                                hb_BackRight,
                                HeadBangerCommandSet.tilt,
                                x => inc(x));

        private void BR_Fade_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue(BR_Fade,
                                hb_BackRight,
                                HeadBangerCommandSet.fade,
                                x => dec(x));

        private void BR_Fade_Up_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Fade,
                                hb_BackRight,
                                HeadBangerCommandSet.fade,
                                x => inc(x));

        private void BR_Red_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Red,
                                hb_BackRight,
                                HeadBangerCommandSet.red,
                                x => dec(x));

        private void BR_Red_Up_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Red,
                                hb_BackRight,
                                HeadBangerCommandSet.red,
                                x => inc(x));

        private void BR_Green_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Green,
                                hb_BackRight,
                                HeadBangerCommandSet.green,
                                x => dec(x));

        private void BR_Green_Up_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Green,
                                hb_BackRight,
                                HeadBangerCommandSet.green,
                                x => inc(x));

        private void BR_Blue_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue(BR_Blue,
                                hb_BackRight,
                                HeadBangerCommandSet.blue,
                                x => dec(x));

        private void BR_Blue_Up_Click(object sender, EventArgs e)
            => SetChannelValue( BR_Blue,
                                hb_BackRight,
                                HeadBangerCommandSet.blue,
                                x => inc(x));

        private void BR_White_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( BR_White,
                                hb_BackRight,
                                HeadBangerCommandSet.white,
                                x => dec(x));

        private void BR_White_Up_Click(object sender, EventArgs e)
            => SetChannelValue(BR_White,
                                hb_BackRight,
                                HeadBangerCommandSet.white,
                                x => inc(x));

        private void FR_Pan_Left_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Pan,
                                hb_FrontRight,
                                HeadBangerCommandSet.pan,
                                x => dec(x));


        private void FR_Pan_Right_Click(object sender, EventArgs e)
            => SetChannelValue(FR_Pan,
                                hb_FrontRight,
                                HeadBangerCommandSet.pan,
                                x => inc(x));

        private void FR_Tilt_Fwd_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Tilt,
                                hb_FrontRight,
                                HeadBangerCommandSet.tilt,
                                x => dec(x));

        private void FR_Tilt_Bck_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Tilt,
                                hb_FrontRight,
                                HeadBangerCommandSet.tilt,
                                x => inc(x));

        private void FR_Fade_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Fade,
                                hb_FrontRight,
                                HeadBangerCommandSet.fade,
                                x => dec(x));

        private void FR_Fade_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Fade,
                                hb_FrontRight,
                                HeadBangerCommandSet.fade,
                                x => inc(x));

        private void FR_Red_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Red,
                                hb_FrontRight,
                                HeadBangerCommandSet.red,
                                x => dec(x));

        private void FR_Red_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Red,
                                hb_FrontRight,
                                HeadBangerCommandSet.red,
                                x => inc(x));

        private void FR_Green_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Green,
                                hb_FrontRight,
                                HeadBangerCommandSet.green,
                                x => dec(x));

        private void FR_Green_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Green,
                                hb_FrontRight,
                                HeadBangerCommandSet.green,
                                x => inc(x));

        private void FR_Blue_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Blue,
                                hb_FrontRight,
                                HeadBangerCommandSet.blue,
                                x => dec(x));

        private void FR_Blue_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FR_Blue,
                                hb_FrontRight,
                                HeadBangerCommandSet.blue,
                                x => inc(x));

        private void FR_White_Dwn_Click(object sender, EventArgs e)
            => SetChannelValue( FR_White,
                                hb_FrontRight,
                                HeadBangerCommandSet.white,
                                x => dec(x));

        private void FR_White_Up_Click(object sender, EventArgs e)
            => SetChannelValue( FR_White,
                                hb_FrontRight,
                                HeadBangerCommandSet.white,
                                x => inc(x));

        private void BR_White_TextChanged(object sender, EventArgs e)
        {

        }

        private void FR_White_TextChanged(object sender, EventArgs e)
        {

        }

        private void FR_Green_TextChanged(object sender, EventArgs e)
        {

        }

        private void FR_Red_TextChanged(object sender, EventArgs e)
        {

        }

        private void FR_Fade_TextChanged(object sender, EventArgs e)
        {

        }

        private void FR_Tilt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FR_Pan_TextChanged(object sender, EventArgs e)
        {

        }

        private void BR_Blue_TextChanged(object sender, EventArgs e)
        {

        }

        private void BR_Green_TextChanged(object sender, EventArgs e)
        {

        }

        private void BR_Red_TextChanged(object sender, EventArgs e)
        {

        }

        private void BR_Fade_TextChanged(object sender, EventArgs e)
        {

        }

        private void BR_Tilt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BR_Pan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
