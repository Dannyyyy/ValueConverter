using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValueConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                try
                {
                    double lenght = Convert.ToDouble(textBox1.Text);
                    Metr metr = new Metr();
                    textBox2.Text = Convert.ToString(metr.getSm(lenght));
                }
                catch (Exception ex)
                {
 
                }
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            { }
            else
            {
                double lenght = Convert.ToDouble(textBox2.Text);
                Sm sm = new Sm();
                textBox1.Text = Convert.ToString(sm.getMetr(lenght));
            }
        }
    }
}
