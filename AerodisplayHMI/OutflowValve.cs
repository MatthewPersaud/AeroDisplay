using System;
using System.Collections.Generic;
using System.Text;

namespace AerodisplayHMI
{
    public class OutflowValve
    {
        static public void openValves()//open the valves
        {
            int miliseconds = Controller.calculateTimeOpen();//simulate time open
            while (miliseconds > 0)
            {
                miliseconds--;
            }
        }
    }
}
