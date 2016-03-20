using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Фут
    public class Foot
    {
        double Metr = 0.305;
        double Dm = 3.048;
        double Sm = 30.48;
        double Mm = 304.8;
        double Vershok = 6.857;
        double Pyad = 1.714;
        double Arshin = 0.429;
        double Sagen = 0.143;
        double Inch = 12;
        double Yard = 0.333;
        double Cable = 0.00165;

        public double getMetr(double ft)
        {
            return ft * Metr;
        }

        public double getPyad(double ft)
        {
            return ft * Pyad;
        }

        public double getDm(double ft)
        {
            return ft * Dm;
        }

        public double getMm(double ft)
        {
            return ft * Mm;
        }

        public double getVershok(double ft)
        {
            return ft * Vershok;
        }

        public double getSm(double ft)
        {
            return ft * Sm;
        }

        public double getArshin(double ft)
        {
            return ft * Arshin;
        }

        public double getSagen(double ft)
        {
            return ft * Sagen;
        }

        public double getInch(double ft)
        {
            return ft * Inch;
        }

        public double getYard(double ft)
        {
            return ft * Yard;
        }

        public double getCable(double ft)
        {
            return ft * Cable;
        }
    }
}
