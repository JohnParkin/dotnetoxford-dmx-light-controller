using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNOLights.HardwareLib;

namespace DNOLights.Desktop
{
    class DMXCommands
    {
        static public Dictionary<HeadBangerCommandSet, byte> LoadHeadbangerSettings()
        {
            var BL_Light = new Dictionary<HeadBangerCommandSet, byte>();

            JObject Light_Settings_All_4_File = JObject.Parse(File.ReadAllText(@"c:\DNOlights\HeadbangerBL.json"));

            // read JSON directly from a file
            using (StreamReader file = File.OpenText(@"c:\DNOlights\HeadbangerBL.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject Settings_All_4 = (JObject)JToken.ReadFrom(reader);
            }

            foreach (HeadBangerCommandSet cmd in Enum.GetValues(typeof(HeadBangerCommandSet)))
            {
                BL_Light.Add(cmd, (byte)Light_Settings_All_4_File["BL_HeadBanger"][cmd.ToString()]);
            }
            return BL_Light;

        }

        static public bool SaveHeadbangerSettings (Dictionary<HeadBangerCommandSet, byte> cmds)
        {
            String json = JsonConvert.SerializeObject(cmds, Newtonsoft.Json.Formatting.Indented);

            System.IO.File.WriteAllText(@"c:\DNOlights\HeadbangerBLSave.json", json);
            return false;
        }

    }

}
