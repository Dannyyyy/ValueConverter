using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Сантиметр
    public class Sm
    {
        double Metr = 0.01;
        double Dm = 0.1;
        double Mm = 10;
        double Vershok = 0.225;
        double Pyad = 0.0562;
        double Arshin = 0.0141;
        double Sagen = 0.00469;
        double Inch = 0.394;
        double Foot = 0.0328;

        public double getMetr(double sm)
        {
            return sm * Metr;
        }

        public double getPyad(double sm)
        {
            return sm * Pyad;
        }

        public double getDm(double sm)
        {
            return sm * Dm;
        }

        public double getVershok(double sm)
        {
            return sm * Vershok;
        }

        public double getMm(double sm)
        {
            return sm * Mm;
        }

        public double getArshin(double sm)
        {
            return sm * Arshin;
        }

        public double getSagen(double sm)
        {
            return sm * Sagen;
        }

        public double getInch(double sm)
        {
            return sm * Inch;
        }

        public double getFoot(double sm)
        {
            return sm * Foot;
        }
    }
}
