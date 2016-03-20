using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Кабельтов
    public class Cable
    {
        double M = 185.2;
        double Sm = 18520;
        double Dm = 1852;
        double Mm = 185200;
        double Vershok = 4166;
        double Pyad = 1042;
        double Arshin = 260.4;
        double Sagen = 86.8;
        double Inch = 7291;
        double Foot = 607.6;
        double Yard = 202.5;

        public double getMetr(double dm)
        {
            return dm * M;
        }

        public double getVershok(double dm)
        {
            return dm * Vershok;
        }

        public double getDm(double dm)
        {
            return dm * Dm;
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

        public double getYard(double dm)
        {
            return dm * Yard;
        }
    }
}
