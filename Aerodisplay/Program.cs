using System;

namespace Aerodisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller.ascend(12000);
            int check = Intercooler.getTemp();
            Controller.ascend(2000);

        }
    }
}
