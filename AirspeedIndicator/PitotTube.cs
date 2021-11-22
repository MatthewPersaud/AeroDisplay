using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirspeedIndicator
{
    public class PitotTube
    {
        float ramPressure;
        float staticPressure;

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
            //Checks that static air pressure is an acceptable value (less than ram air pressure and greater than 0)
            if(pressure > ramPressure)
                staticPressure = ramPressure;

            else if (pressure < 0)
                    staticPressure = 0;

            else
                staticPressure = pressure;
        }

        public void modifyRamAirPressure(float pressure)
        {
            //Checks that ram air pressure is an acceptable value (upper and lower limits are in the 'Constants' class)
            if (pressure > Constants.maxRamAirPressure)
                ramPressure = Constants.maxRamAirPressure;

            else if (pressure < Constants.minRamAirPressure)
                ramPressure = Constants.minRamAirPressure;

            ramPressure = pressure;
        }
    }
}
