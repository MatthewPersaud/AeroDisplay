using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerodisplayHMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RamPressureData.readRamPressureDataFile();
            PitotTube pTube = new PitotTube();
            AirspeedIndicator AIR = new AirspeedIndicator();
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            string val = Altimeter.GetAltitude().ToString();
            altitude.Text = val;

            rampressure.Text = RamPressureData.getRamPressureData().ToString();
            airspeedindicator.Text = AirspeedIndicator.calculateVelocity(AirspeedIndicator.calculateDynamicPressure(float.Parse(rampressure.Text), float.Parse(staticpressure.Text))).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //kollsmanwindow
        {
            string value = kollsmanwindow.Text;
            KollsmanWindow.newPressure(value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (powerbutton.Text == "Take Off") //take off!
            {
                powerbutton.Text = "Land";
                Controller.ascend(12000);
                Application.Idle += Application_Idle;

                rampressure.Text = RamPressureData.getRamPressureData().ToString();
            }
            else if (powerbutton.Text == "Land") //landing the plane!
            {
                powerbutton.Text = "Take Off";
                Application.Idle -= Application_Idle;
                // call Controller.descend() protocol
            }
        }

        private void airspeedindicator_Click(object sender, EventArgs e)
        {

        }
    }
}
