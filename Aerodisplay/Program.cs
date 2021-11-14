using System;

namespace Aerodisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            KollsmanWindow KW = new KollsmanWindow();
            AirDataComputer ADC = new AirDataComputer();
            Altimeter ALT = new Altimeter();

            bool success = KW.newPressure("31.88");

            if (success)
            {
                ALT.adjustAltitude(KW.GetPressure(), ADC.getAltitudeData());
                Console.WriteLine(ALT.GetAltitude());
            }
            else
                Console.WriteLine("Something went wrong");
        }
    }
}
