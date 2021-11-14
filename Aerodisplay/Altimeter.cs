using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodisplay
{
    class Altimeter
    {
        int altitude;

        public void SetAltitude(int a)
        {
            altitude = a;
        }

        public int GetAltitude()
        {
            return altitude;
        }

        public void adjustAltitude(double KWpressure, int ADCalt) //takes pressure from Kollsman Window and altitude from ADC
        {
            //pressure altitude = (standard pressure - your current pressure setting) x 1,000 + field elevation
            double presaltdbl = (29.92 - KWpressure) * 1000 + ADCalt;

            //the altitude of a plane is measured in tens of thousands of feet
            int pressurealtitude = Convert.ToInt32(presaltdbl); //so we round to the nearest foot

            SetAltitude(pressurealtitude);
        }
    }
}
