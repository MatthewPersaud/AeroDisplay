using System;
using System.Collections.Generic;
using System.Text;

namespace Aerodisplay
{
    public class turboFanEngine
    {
        const float IDEALGASCONSTANT = 8.3145f; //constants for math
        const int VOLUME = 12000;
        const int MOLESGAS = 8000;
        static private int randomIndex; //hidden variables
        static private string[] currentPressure;
        static private string[] currentTemp;
        static private float desiredPressure;


        static public int adjustPressure()//adjust exterrior pressure to be safe for humans
        {
            int desiredTemp = Int32.Parse(currentTemp[randomIndex]) * (int)((int)((float.Parse(currentPressure[randomIndex]) + desiredPressure) * VOLUME) / (MOLESGAS * IDEALGASCONSTANT));
            InterriorPressureSensors.setInteriorPressure(float.Parse(currentPressure[randomIndex]));
            if (randomIndex < 59) //increase index
                randomIndex++;
            else
                randomIndex = 0;
            return desiredTemp;
        }
        static public void setDesired(float newPressure)//set the new desired pressure
        {
            desiredPressure = newPressure;
        }
        static public float checkPressure()//check the current exterior pressure
        {
            return float.Parse(currentPressure[randomIndex]);
        }
        static public void setCurrentArray()//initialize the random data
        {
            currentPressure = Controller.readFiles("PressureCurrent.txt");
            currentTemp = Controller.readFiles("Temperature.txt");
            randomIndex = 0;
        }
    }
}
