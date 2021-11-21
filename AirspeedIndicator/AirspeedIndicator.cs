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
        float velocity;

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

        public float getVelocity()
        {
            return velocity;
        }

        public void setVelocity(float v)
        {
            velocity = v;
        }

        public float calculateVelocity(float dynamicPressure)
        {
            setVelocity((float)(Math.Sqrt((((dynamicPressure * 1000) * 2) / 1.23)) * 1.944));  //make 1.23 and 1.944 constants? Define it or something
            
            return getVelocity();
        }
    }
}
