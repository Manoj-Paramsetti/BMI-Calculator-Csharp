using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        float feet;
        float inches;
        float cm;
        float kg;
        float pounds;

        bool show1 = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (show1)
            {
                float BMI = (pounds / ((feet * 12) + inches) / ((feet * 12) + inches)) * 703;
                label12.Text = "" + (BMI);
            }
        }
        
        private void textBoxCM_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(textBoxCM.Text, out var s)))
            {
                cm = float.Parse(textBoxCM.Text);
                show1 = true;
            }
            else{
                label12.Text = "Invalid Number";
                show1 = false;
            }
        }

        private void textBoxFeet_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(textBoxFeet.Text, out var s)))
            {
                show1 = true;
                feet = float.Parse(textBoxFeet.Text);
            }
            else
            {
                show1 = false;
                label12.Text = "Invalid Number";
            }
        }

        private void textBoxInches_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(textBoxInches.Text, out var s)))
            {
                show1 = true;
                inches = float.Parse(textBoxInches.Text);
            }
            else
            {
                show1 = false;
                label12.Text = "Invalid Number";
            }
        }

        private void textBoxPounds_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(textBoxPounds.Text, out var s)))
            {
                show1 = true;
                pounds = float.Parse(textBoxPounds.Text);
            }
            else
            {
                show1 = false;
                label12.Text = "Invalid Number";
            }
        }

        private void textBoxKG_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(textBoxKG.Text, out var s)) )
            {
                show1 = true;
                kg = float.Parse(textBoxKG.Text);
            }
            else
            {
                show1 = false;
                label12.Text = "Invalid Number";
            }
        }

        private void calculateMetric_Click(object sender, EventArgs e)
        {
            float BMI = (kg / (cm * cm) *10000);
            label14.Text = ""+BMI;
        }

       
    }
}
