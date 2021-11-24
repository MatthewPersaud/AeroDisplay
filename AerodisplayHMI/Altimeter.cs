using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerodisplayHMI
{
    class Altimeter
    {
        private int altitude;
        //altimter has its own air data computer and kollsman window
        private KollsmanWindow KW = new KollsmanWindow();
        private AirDataComputer ADC = new AirDataComputer();

        public void SetAltitude(int a)
        {
            altitude = a;
        }

        public KollsmanWindow GetKW()
        {
            return KW;
        }

        public int GetAltitude() //calculates altitude, then returns it
        {
            //pressure altitude = (standard pressure - your current pressure setting) x 1,000 + field elevation
            double presaltdbl = (29.92 - KW.GetPressure()) * 1000 + ADC.getAltitudeData();

            //the altitude of a plane is measured in tens of thousands of feet
            int pressurealtitude = Convert.ToInt32(presaltdbl); //so we round to the nearest foot

            SetAltitude(pressurealtitude);
            return altitude;
        }
    }
}
