using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirspeedIndicator
{
    public class RamPressureData
    {
        int index = 0;

        public int getIndex()
        {
            return index;
        }

        public void setIndex(int i)
        {
            index = i;
        }

        public static string[] readRamPressureDataFile()
        {
            string fileName = "DefaultRamPressureData.txt";

            string[] lines = System.IO.File.ReadAllLines(fileName);

            return lines;
        }

        public float getRamPressureData()
        {
            string[] data = readRamPressureDataFile();
            int index = getIndex();
            float ramPressureData = float.Parse(data[index]);

            if (index == 49)
                setIndex(0);

            else
                setIndex(index + 1);

            return ramPressureData;
        }
    }
}
