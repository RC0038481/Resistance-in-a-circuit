using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistance_in_a_circuit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double Resistance8 = double.Parse(ResistanceH.Text);
            double Resistance9 = double.Parse(ResistanceI.Text);
            double Resistance10 = double.Parse(ResistanceJ.Text);

            double ResistanceTotal4 = 1.0 / (1.0 / Resistance8) + (1.0 / Resistance9) + (1.0 / Resistance10);
            ResistanceTotalD.Text = ResistanceTotal4.ToString("0.0");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)

        {

            double Resistance1;
            try
            {
                Resistance1 = double.Parse(ResistanceA.Text);
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance1 = 0.0;
            }

            double Resistance2;
            try
            {
                Resistance2 = double.Parse(ResistanceB.Text);
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance2 = 0.0;
            }
            double ResistanceTotal1 = Resistance1 + Resistance2;
            ResistanceTotalA.Text = ResistanceTotal1.ToString("0");
        }
    private void Resistance1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resistance2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResistanceTotal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double Resistance5;
            try
            {
                Resistance5 = double.Parse(ResistanceE.Text);
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
            }
            double Resistance6;
            try
            {
                Resistance6 = double.Parse(ResistanceF.Text);
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
            }
            double Resistance7;
            try
            {
                Resistance7 = double.Parse(ResistanceG.Text);
            }
            catch
            {
                MessageBox.Show("R3 is not a valid value");
            }
            double ResistanceTotal3 = Resistance5 + Resistance6 + Resistance7;
            ResistanceTotalC.Text = ResistanceTotal3.ToString("0");
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double Resistance3;
            try
            {
                Resistance3 = double.Parse(ResistanceC.Text);
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance3 = 0.0;
            }

            double Resistance4;
            try
            {
                Resistance4 = double.Parse(ResistanceD.Text);
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance4 = 0.0;
            }
            double ResistanceTotal2 = 1.0 / (1.0 / Resistance3 + 1.0 / Resistance4);
            ResistanceTotalB.Text = ResistanceTotal2.ToString("0.0");
        }
    }
}
