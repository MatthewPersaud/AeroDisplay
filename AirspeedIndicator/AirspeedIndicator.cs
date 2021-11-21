using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirspeedIndicator
{
    class AirspeedIndicator
    {
        float dynamicPressure;

        public float getDynamicPressure()
        {
            return dynamicPressure;
        }

        public void setDynamicPressure(float pressure)
        {
            dynamicPressure = pressure;
        }

        public float calculateDynamicPressure(float ramPressure, float staticPressure)
        { 

            setDynamicPressure(ramPressure - staticPressure);

            return getDynamicPressure();
        }





    }
}
