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
                        textBox5.Text = Convert.ToString(metr.getInch(lenght));
                        textBox6.Text = Convert.ToString(metr.getSpan(lenght));
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
                        textBox5.Text = Convert.ToString(sm.getInch(lenght));
                        textBox6.Text = Convert.ToString(sm.getSpan(lenght));
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
                        textBox5.Text = Convert.ToString(dm.getInch(lenght));
                        textBox6.Text = Convert.ToString(dm.getSpan(lenght));
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
                        textBox5.Text = Convert.ToString(mm.getInch(lenght));
                        textBox6.Text = Convert.ToString(mm.getSpan(lenght));
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox5.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox5.Text);
                        Inch inch = new Inch();
                        textBox1.Text = Convert.ToString(inch.getMetr(lenght));
                        textBox2.Text = Convert.ToString(inch.getSm(lenght));
                        textBox3.Text = Convert.ToString(inch.getDm(lenght));
                        textBox4.Text = Convert.ToString(inch.getMm(lenght));
                        textBox6.Text = Convert.ToString(inch.getSpan(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox5.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox6.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox6.Text);
                        Span span = new Span();
                        textBox1.Text = Convert.ToString(span.getMetr(lenght));
                        textBox2.Text = Convert.ToString(span.getSm(lenght));
                        textBox3.Text = Convert.ToString(span.getDm(lenght));
                        textBox4.Text = Convert.ToString(span.getMm(lenght));
                        textBox5.Text = Convert.ToString(span.getInch(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox6.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }
    }
}
