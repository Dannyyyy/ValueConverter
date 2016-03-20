using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Дециметр
    public class Dm
    {
        double M = 0.1;
        double Sm = 10;
        double Mm = 100;
        double Vershok = 2.25;
        double Pyad = 0.562;
        double Arshin = 0.141;
        double Sagen = 0.0469;
        double Inch = 3.937;
        double Foot = 0.328;

        public double getMetr(double dm)
        {
            return dm * M;
        }

        public double getVershok(double dm)
        {
            return dm * Vershok;
        }

        public double getSm(double dm)
        {
            return dm * Sm;
        }

        public double getPyad(double dm)
        {
            return dm * Pyad;
        }

        public double getMm(double dm)
        {
            return dm * Mm;
        }

        public double getArshin(double dm)
        {
            return dm * Arshin;
        }

        public double getSagen(double dm)
        {
            return dm * Sagen;
        }

        public double getInch(double dm)
        {
            return dm * Inch;
        }

        public double getFoot(double dm)
        {
            return dm * Foot;
        }
    }
}
