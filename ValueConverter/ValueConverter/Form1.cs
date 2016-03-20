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

        //Метр
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
                        textBox5.Text = Convert.ToString(metr.getVershok(lenght));
                        textBox6.Text = Convert.ToString(metr.getPyad(lenght));
                        textBox7.Text = Convert.ToString(metr.getArshin(lenght));
                        textBox8.Text = Convert.ToString(metr.getSagen(lenght));
                        textBox9.Text = Convert.ToString(metr.getFoot(lenght));
                        textBox10.Text = Convert.ToString(metr.getInch(lenght));
                        textBox11.Text = Convert.ToString(metr.getCable(lenght));
                        textBox12.Text = Convert.ToString(metr.getYard(lenght));
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

        //Сантиметр
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
                        textBox5.Text = Convert.ToString(sm.getPyad(lenght));
                        textBox6.Text = Convert.ToString(sm.getPyad(lenght));
                        textBox7.Text = Convert.ToString(sm.getArshin(lenght));
                        textBox8.Text = Convert.ToString(sm.getSagen(lenght));
                        textBox9.Text = Convert.ToString(sm.getFoot(lenght));
                        textBox10.Text = Convert.ToString(sm.getInch(lenght));
                        textBox11.Text = Convert.ToString(sm.getCable(lenght));
                        textBox12.Text = Convert.ToString(sm.getYard(lenght));
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

        //Дециметр
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
                        textBox5.Text = Convert.ToString(dm.getVershok(lenght));
                        textBox6.Text = Convert.ToString(dm.getPyad(lenght));
                        textBox7.Text = Convert.ToString(dm.getArshin(lenght));
                        textBox8.Text = Convert.ToString(dm.getSagen(lenght));
                        textBox9.Text = Convert.ToString(dm.getFoot(lenght));
                        textBox10.Text = Convert.ToString(dm.getInch(lenght));
                        textBox11.Text = Convert.ToString(dm.getCable(lenght));
                        textBox12.Text = Convert.ToString(dm.getYard(lenght));
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

        //Миллиметр
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
                        textBox5.Text = Convert.ToString(mm.getVershok(lenght));
                        textBox6.Text = Convert.ToString(mm.getPyad(lenght));
                        textBox7.Text = Convert.ToString(mm.getArshin(lenght));
                        textBox8.Text = Convert.ToString(mm.getSagen(lenght));
                        textBox9.Text = Convert.ToString(mm.getFoot(lenght));
                        textBox10.Text = Convert.ToString(mm.getInch(lenght));
                        textBox11.Text = Convert.ToString(mm.getCable(lenght));
                        textBox12.Text = Convert.ToString(mm.getYard(lenght));
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

        //Вершок
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
                        Vershok vershok = new Vershok();
                        textBox1.Text = Convert.ToString(vershok.getMetr(lenght));
                        textBox2.Text = Convert.ToString(vershok.getSm(lenght));
                        textBox3.Text = Convert.ToString(vershok.getDm(lenght));
                        textBox4.Text = Convert.ToString(vershok.getMm(lenght));
                        textBox6.Text = Convert.ToString(vershok.getPyad(lenght));
                        textBox7.Text = Convert.ToString(vershok.getArshin(lenght));
                        textBox8.Text = Convert.ToString(vershok.getSAgen(lenght));
                        textBox9.Text = Convert.ToString(vershok.getFoot(lenght));
                        textBox10.Text = Convert.ToString(vershok.getInch(lenght));
                        textBox11.Text = Convert.ToString(vershok.getCable(lenght));
                        textBox12.Text = Convert.ToString(vershok.getYard(lenght));
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

        //Пядь
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
                        Pyad pyad = new Pyad();
                        textBox1.Text = Convert.ToString(pyad.getMetr(lenght));
                        textBox2.Text = Convert.ToString(pyad.getSm(lenght));
                        textBox3.Text = Convert.ToString(pyad.getDm(lenght));
                        textBox4.Text = Convert.ToString(pyad.getMm(lenght));
                        textBox5.Text = Convert.ToString(pyad.getVershok(lenght));
                        textBox7.Text = Convert.ToString(pyad.getArshin(lenght));
                        textBox8.Text = Convert.ToString(pyad.getSagen(lenght));
                        textBox9.Text = Convert.ToString(pyad.getFoot(lenght));
                        textBox10.Text = Convert.ToString(pyad.getInch(lenght));
                        textBox11.Text = Convert.ToString(pyad.getCable(lenght));
                        textBox12.Text = Convert.ToString(pyad.getYard(lenght));
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

        //Аршин
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox7.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox7.Text);
                        Arshin arshin = new Arshin();
                        textBox1.Text = Convert.ToString(arshin.getMetr(lenght));
                        textBox2.Text = Convert.ToString(arshin.getSm(lenght));
                        textBox3.Text = Convert.ToString(arshin.getDm(lenght));
                        textBox4.Text = Convert.ToString(arshin.getMm(lenght));
                        textBox5.Text = Convert.ToString(arshin.getVershok(lenght));
                        textBox6.Text = Convert.ToString(arshin.getPyad(lenght));
                        textBox8.Text = Convert.ToString(arshin.getSagen(lenght));
                        textBox9.Text = Convert.ToString(arshin.getFoot(lenght));
                        textBox10.Text = Convert.ToString(arshin.getInch(lenght));
                        textBox11.Text = Convert.ToString(arshin.getCable(lenght));
                        textBox12.Text = Convert.ToString(arshin.getYard(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox7.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        //Сажень
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox8.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox8.Text);
                        Sagen sagen = new Sagen();
                        textBox1.Text = Convert.ToString(sagen.getMetr(lenght));
                        textBox2.Text = Convert.ToString(sagen.getSm(lenght));
                        textBox3.Text = Convert.ToString(sagen.getDm(lenght));
                        textBox4.Text = Convert.ToString(sagen.getMm(lenght));
                        textBox5.Text = Convert.ToString(sagen.getVershok(lenght));
                        textBox6.Text = Convert.ToString(sagen.getPyad(lenght));
                        textBox7.Text = Convert.ToString(sagen.getArshin(lenght));
                        textBox9.Text = Convert.ToString(sagen.getFoot(lenght));
                        textBox10.Text = Convert.ToString(sagen.getInch(lenght));
                        textBox11.Text = Convert.ToString(sagen.getCable(lenght));
                        textBox12.Text = Convert.ToString(sagen.getYard(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox8.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox9.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox9.Text);
                        Foot ft = new Foot();
                        textBox1.Text = Convert.ToString(ft.getMetr(lenght));
                        textBox2.Text = Convert.ToString(ft.getSm(lenght));
                        textBox3.Text = Convert.ToString(ft.getDm(lenght));
                        textBox4.Text = Convert.ToString(ft.getMm(lenght));
                        textBox5.Text = Convert.ToString(ft.getVershok(lenght));
                        textBox6.Text = Convert.ToString(ft.getPyad(lenght));
                        textBox7.Text = Convert.ToString(ft.getArshin(lenght));
                        textBox8.Text = Convert.ToString(ft.getSagen(lenght));
                        textBox10.Text = Convert.ToString(ft.getInch(lenght));
                        textBox11.Text = Convert.ToString(ft.getCable(lenght));
                        textBox12.Text = Convert.ToString(ft.getYard(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox9.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox10.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox10.Text);
                        Inch inch = new Inch();
                        textBox1.Text = Convert.ToString(inch.getMetr(lenght));
                        textBox2.Text = Convert.ToString(inch.getSm(lenght));
                        textBox3.Text = Convert.ToString(inch.getDm(lenght));
                        textBox4.Text = Convert.ToString(inch.getMm(lenght));
                        textBox5.Text = Convert.ToString(inch.getVershok(lenght));
                        textBox6.Text = Convert.ToString(inch.getPyad(lenght));
                        textBox7.Text = Convert.ToString(inch.getArshin(lenght));
                        textBox8.Text = Convert.ToString(inch.getSagen(lenght));
                        textBox9.Text = Convert.ToString(inch.getFoot(lenght));
                        textBox11.Text = Convert.ToString(inch.getCable(lenght));
                        textBox12.Text = Convert.ToString(inch.getYard(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox10.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox12.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox12.Text);
                        Yard yard = new Yard();
                        textBox1.Text = Convert.ToString(yard.getMetr(lenght));
                        textBox2.Text = Convert.ToString(yard.getSm(lenght));
                        textBox3.Text = Convert.ToString(yard.getDm(lenght));
                        textBox4.Text = Convert.ToString(yard.getMm(lenght));
                        textBox5.Text = Convert.ToString(yard.getVershok(lenght));
                        textBox6.Text = Convert.ToString(yard.getPyad(lenght));
                        textBox7.Text = Convert.ToString(yard.getArshin(lenght));
                        textBox8.Text = Convert.ToString(yard.getSagen(lenght));
                        textBox9.Text = Convert.ToString(yard.getFoot(lenght));
                        textBox10.Text = Convert.ToString(yard.getInch(lenght));
                        textBox11.Text = Convert.ToString(yard.getCable(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox12.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (!activeTextBox)
            {
                if (textBox11.Text != "")
                {
                    try
                    {
                        activeTextBox = true;
                        double lenght = Convert.ToDouble(textBox11.Text);
                        Cable cable = new Cable();
                        textBox1.Text = Convert.ToString(cable.getMetr(lenght));
                        textBox2.Text = Convert.ToString(cable.getSm(lenght));
                        textBox3.Text = Convert.ToString(cable.getDm(lenght));
                        textBox4.Text = Convert.ToString(cable.getMm(lenght));
                        textBox5.Text = Convert.ToString(cable.getVershok(lenght));
                        textBox6.Text = Convert.ToString(cable.getPyad(lenght));
                        textBox7.Text = Convert.ToString(cable.getArshin(lenght));
                        textBox8.Text = Convert.ToString(cable.getSagen(lenght));
                        textBox9.Text = Convert.ToString(cable.getFoot(lenght));
                        textBox10.Text = Convert.ToString(cable.getInch(lenght));
                        textBox12.Text = Convert.ToString(cable.getYard(lenght));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в вводимого значения");
                        textBox11.Clear();
                    }
                    activeTextBox = false;
                }
            }
        }
    }
}
