using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Aerodisplay
{
    class AirDataComputer
    {
        public static void ReadData()
        {
            string fileName = "altimeterdata.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName); 
            //not sure if above works outside Debug mode

            string[] lines = File.ReadAllLines(path);
            /*
            foreach (string r in lines)
            {
                Console.WriteLine("-- {0}", r);
            }*/


        }
    }
}
