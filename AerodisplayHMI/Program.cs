using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerodisplayHMI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void StartPlane(Form1 form)
        {
            Controller.ascend(12000);
            //bool flying = true;
            int index = 42;

            while (index > 0)
            {
                string val = Altimeter.GetAltitude().ToString();
                form.adjustAlt(val);
                index--;
            }
            //int check = Intercooler.getTemp();
            //Controller.ascend(2000);
            //Altimeter.GetAltitude();
        }
    }
}
