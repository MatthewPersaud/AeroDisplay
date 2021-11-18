using System;
using System.Collections.Generic;
using System.Text;


namespace Aerodisplay
{
    public class InterriorPressureSensors
    {
        static private float pressure;
        static private string[] pressureMod;
        static private int index;

        static public float checkInteriorPressure()//basic check call
        {
            return pressure;
        }

        static public void setInteriorPressure(float newPressure)//set the pressure based off the enging
        {
            if (index <= 59)
            {
                index++;
                pressure = newPressure * float.Parse(pressureMod[index - 1]); //apply random mod 
            }
            else
            {
                index = 0;
                pressure = newPressure * float.Parse(pressureMod[index]);
            }
        }

        static public void setPressureMod()//read from file
        {
            pressureMod = Controller.readFiles("PressureIn.txt");
            index = 0;
        }

    }
}
