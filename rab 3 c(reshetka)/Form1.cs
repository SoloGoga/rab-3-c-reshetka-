using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rab_3_c_reshetka_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Drob d1 = new Drob(1, 1), d2 = new Drob(1, 1), d3 = new Drob(1, 1), R = new Drob(1, 1);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 1;
            numericUpDown6.Value = 1;
            textBox7.Text = " ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1.chis = (int)numericUpDown1.Value;
            d1.znam = (int)numericUpDown4.Value;

            d2.chis = (int)numericUpDown2.Value;
            d2.znam = (int)numericUpDown5.Value;

            d3.chis = (int)numericUpDown3.Value;
            d3.znam = (int)numericUpDown6.Value;

            R = (d1 + d2) * (d1 - d3);

            textBox7.Text = "R ravno " + "\r\n" + Drob.Vivod(R) + "\r\n" + "\r\n" + "1/R ravno " + "\r\n" + Drob.Vivod(1 / R);
        }

    }
}
