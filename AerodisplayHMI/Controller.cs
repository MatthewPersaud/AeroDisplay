using System;
using System.Collections.Generic;
using System.Text;

namespace AerodisplayHMI
{
    public class Controller
    {

        static public void ascend(int desiredHeight)//set system to settings for going up
        {
            InterriorPressureSensors.setPressureMod();
            turboFanEngine.setCurrentArray();
            Intercooler.changeDesTemp(22);
            turboFanEngine.setDesired(14.6f * 1 + (desiredHeight / 20000));
            OutflowValve.openValves();
            Intercooler.coolDown();
        }

        static public void fly() //set system to setting for flying
        {
            turboFanEngine.setDesired(determOptPres(turboFanEngine.checkPressure(), InterriorPressureSensors.checkInteriorPressure()));
            OutflowValve.openValves();
            Intercooler.coolDown();
        }

        static public void descend() //set system to setting for going down
        {
            turboFanEngine.setDesired(14.6f);
            OutflowValve.openValves();
            Intercooler.coolDown();
        }

        static public string[] readFiles(string fileName)//read from random files
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            return lines;
        }

        static public float determOptPres(float exteriorPressure, float interiorPressure) //determine the optimal pressure
        {
            //this math was very complicated with the armstrong limit and comparing mbar to PSIa and PSI as well as yield strength so i gave up and made up math
            float differencePressure = exteriorPressure - interiorPressure;
            float optimal;

            if (differencePressure > 1200) //make sure wont break hull
            {
                optimal = interiorPressure + 10;
            }
            else if (interiorPressure > 14.6)//adjust pressure slowly
            {
                optimal = interiorPressure - 1;
            }
            else if (differencePressure < 14.6)
            {
                optimal = interiorPressure + 1;
            }
            else
            {
                optimal = 14.6f;
            }
            return optimal;
        }

        public static int calculateTimeOpen() //calculate how long valves need to be open
        {
            int timeOpen;
            float wanted = turboFanEngine.checkPressure(); //check pressures to know
            float current = InterriorPressureSensors.checkInteriorPressure();
            if (current >= wanted)
            {
                timeOpen = (int)(current - wanted);
            }
            else
            {
                timeOpen = (int)(wanted - current);
            }
            return timeOpen;
        }

    }
}
