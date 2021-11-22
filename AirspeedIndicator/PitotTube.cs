using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirspeedIndicator
{
    public class PitotTube
    {
        float ramPressure = 0;
        float staticPressure = 50;

        public float getStaticAirPressure()
        {
            return staticPressure;
        }

        public float getRamAirPressure()
        {
            return ramPressure;
        }

        public void modifyStaticAirPressure(float pressure)
        {
            if(pressure > ramPressure)
                staticPressure = ramPressure;

            else if (pressure < 0)
                    staticPressure = 0;

            else
                staticPressure = pressure;
        }

        public void modifyRamAirPressure(float pressure)
        {
            

            ramPressure = pressure;
        }
    }
}
