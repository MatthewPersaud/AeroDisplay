using System;

namespace Aerodisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            KollsmanWindow KW = new KollsmanWindow();

            string p = "a";
            bool b = KW.newPressure(p);
            if (b)
                Console.WriteLine(KW.GetPressure());
            else
                Console.WriteLine("NOT A VALID NUMBER");
        }
    }
}
