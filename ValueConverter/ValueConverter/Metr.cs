using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Метр
    public class Metr
    {
        double Dm = 10;
        double Sm = 100;
        double Mm = 1000;
        double Vershok = 22.5;
        double Pyad = 5.624;
        double Arshin = 1.406;
        double Sagen = 0.469;
        double Inch = 39.37;
        double Foot = 3.281;
        double Yard = 1.094;
        double Cable = 0.0054;

        public double getDm(double m)
        {
            return m * Dm;
        }

        public double getVershok(double m)
        {
            return m * Vershok;
        }

        public double getPyad(double m)
        {
            return m * Pyad;
        }

        public double getSm(double m)
        {
            return m * Sm;
        }

        public double getMm(double m)
        {
            return m * Mm;
        }

        public double getArshin(double m)
        {
            return m * Arshin;
        }

        public double getSagen(double m)
        {
            return m * Sagen;
        }

        public double getInch(double m)
        {
            return m * Inch;
        }

        public double getFoot(double m)
        {
            return m * Foot;
        }

        public double getYard(double m)
        {
            return m * Yard;
        }

        public double getCable(double m)
        {
            return m * Cable;
        }
    }
}
