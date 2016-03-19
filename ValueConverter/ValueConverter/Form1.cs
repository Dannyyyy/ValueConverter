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
        bool activeTextBox = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox1.Text);
                        Metr metr = new Metr();
                        textBox2.Text = Convert.ToString(metr.getSm(lenght));
                        textBox3.Text = Convert.ToString(metr.getDm(lenght));
                        textBox4.Text = Convert.ToString(metr.getMm(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox1.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox2.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox2.Text);
                        Sm sm = new Sm();
                        textBox1.Text = Convert.ToString(sm.getMetr(lenght));
                        textBox3.Text = Convert.ToString(sm.getDm(lenght));
                        textBox4.Text = Convert.ToString(sm.getMm(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox2.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox3.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox3.Text);
                        Dm dm = new Dm();
                        textBox1.Text = Convert.ToString(dm.getMetr(lenght));
                        textBox2.Text = Convert.ToString(dm.getSm(lenght));
                        textBox4.Text = Convert.ToString(dm.getMm(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox3.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox4.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox4.Text);
                        Mm mm = new Mm();
                        textBox1.Text = Convert.ToString(mm.getMetr(lenght));
                        textBox2.Text = Convert.ToString(mm.getSm(lenght));
                        textBox3.Text = Convert.ToString(mm.getDm(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox4.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }
    }
}
