using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodisplay
{
    class KollsmanWindow
    {
        double pressure = 29.92; //default Kollsman Window value
        //air pressure at sea level

        public double GetPressure()
        {
            return pressure;
        }

        public void SetPressure(double p)
        {
            pressure = p;
        }

        public bool newPressure(string p) //gets the value entered in the UI and sets the pressure
        { //returns a bool, true if it was a success, false if it was a failure
            double newpressure;
            bool isDouble = double.TryParse(p, out newpressure);

            if (isDouble) //if this succeeds, then string p was a valid pressure
                SetPressure(newpressure); //set the pressure to the altimeter
            return isDouble; 
        }

    }
}
