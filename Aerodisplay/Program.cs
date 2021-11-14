using System;

namespace Aerodisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            AirDataComputer ADC = new AirDataComputer();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(ADC.getAltitudeData());
            }
        }
    }
}
