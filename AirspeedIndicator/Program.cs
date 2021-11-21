using System;

namespace AirspeedIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            AirspeedIndicator air = new AirspeedIndicator();
            PitotTube ptube = new PitotTube();
            
            Console.WriteLine("ram stuff...");
            ptube.modifyRamAirPressure(100);
            Console.WriteLine("ram pressure is {0}", ptube.getRamAirPressure());


            Console.WriteLine("\n\nstatic stuff...");
            ptube.modifyStaticAirPressure(57);
            Console.WriteLine("static pressure is {0}", ptube.getStaticAirPressure());

            
            Console.WriteLine("\n\ndynamic stuff...");
            air.calculateDynamicPressure(ptube.getRamAirPressure(), ptube.getStaticAirPressure());
            Console.WriteLine("dynamic pressure is {0}", air.getDynamicPressure());


            Console.WriteLine("\n\nvelocity stuff...");
            air.calculateVelocity(air.getDynamicPressure());
            Console.WriteLine("velocity is {0} knots", air.getVelocity());
        }
    }
}
