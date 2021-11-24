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
            string val = Altimeter.GetAltitude().ToString();
            altitudelabel.Text = val;
        }

        public void running()
        {

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
                //call controller.ascend protocol
                //then call controller.fly protocol?
            }
            else if (powerbutton.Text == "Land") //landing the plane!
            {
                powerbutton.Text = "Take Off";
                // call Controller.descend() protocol
            }
        }
    }
}
