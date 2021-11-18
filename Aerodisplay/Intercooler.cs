using System;
using System.Collections.Generic;
using System.Text;

namespace Pressure
{
    public class Intercooler
    {
        static private int desiredTemp;
        static public void coolDown()//change the air temp to desired
        {
            int currentTemp = turboFanEngine.adjustPressure();
            while (currentTemp > desiredTemp)
            {
                currentTemp--;
            }
            while (currentTemp < desiredTemp)
            {
                currentTemp++;
            }
        }
        public static void changeDesTemp(int newTemp)//lets the pilot change the desired temp
        {
            desiredTemp = newTemp;
        }
    }
}
