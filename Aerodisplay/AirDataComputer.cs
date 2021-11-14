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
        int index = 0; //where in the data file we left off

        public int GetIndex()
        {
            return index;
        }

        public void SetIndex(int i)
        {
            index = i;
        }

        public static string[] ReadData()
        {
            string fileName = "altimeterdata.txt"; //name of the data file
            //file is in debug, in a Data folder
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName); 
            //not sure if above works outside Debug mode

            string[] lines = File.ReadAllLines(path); //read file and put it in an array

            return lines;
        }

        public int getAltitudeData() //gets the current altitude from the ADC
        {
            string[] lines = ReadData();
            int i = GetIndex();
            int altitude = int.Parse(lines[i]);

            if (i == 59) //once we reach the end of the file...
                SetIndex(0); //reset to the top
            else
                SetIndex(i + 1); //use the next piece of data next time

            return altitude;
        }

    }
}
