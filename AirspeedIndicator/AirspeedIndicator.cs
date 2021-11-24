using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirspeedIndicator
{
    static class Constants
    {
        public const double pressure = 1.23; 
        public const double velocityConvertion = 1.944; //conversion from metres/sec to knots
        public const int maxRamAirPressure = 105;  //highest ram air pressure allowed in system
        public const int minRamAirPressure = 40;   //lowest ram air pressure allowed in system
    }

    class AirspeedIndicator
    {
        float dynamicPressure = 0;
        float velocity = 0;

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
            //Calculation to find the velocity in knots
            setVelocity((float)(Math.Sqrt((((dynamicPressure * 1000) * 2) / Constants.pressure)) * Constants.velocityConvertion));

            return getVelocity();
        }
    }
}
