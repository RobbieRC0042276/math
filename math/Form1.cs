using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return(Math.Asin(x) * 180 / Math.PI);
        }

        double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 180.0));
        }

        double atan(double x)
        {
            return(Math.Atan(x) * 180 / Math.PI);
        }

        double Cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads what text is in the force and angle textboxs
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);
                //Inputs the numbers into the equation
                double FX = Force * Cos(Angle);
                double FY = Angle * sin(Angle);
                //Rewrites the answers into the label 
                label5.Text = "Fy = " + FY;
                label4.Text = "Fx = " + FX;
            }
            catch
            {
                //shows an message if an error occurs
                MessageBox.Show("your nu,bers are wrong, check again");
            }

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
