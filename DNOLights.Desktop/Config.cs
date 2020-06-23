using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DNOLights.Desktop
{
    public class Config
    {
        string configpath = @"c:\DNOlights\HeadbangerBL.json";
        public static void configFileInit()
        {
            string path = @"c:\DNOlights\HeadbangerBL.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("pan:128");
                    sw.WriteLine("tilt:128");
                    sw.WriteLine("fade:200");
                    sw.WriteLine("red:0");
                    sw.WriteLine("green:0");
                    sw.WriteLine("blue:0");
                    sw.WriteLine("white:0");
                }
            }
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}
