using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Пядь
    public class Pyad
    {
        double Metr = 0.178;
        double Dm = 1.778;
        double Sm = 17.78;
        double Mm = 177.8;
        double Vershok = 4;
        double Arshin = 0.25;
        double Sagen = 0.0833;
        double Inch = 7;
        double Foot = 0.583;
        double Yard = 0.194;
        double Cable = 0.00096;

        public double getMetr(double pyad)
        {
            return pyad * Metr;
        }

        public double getDm(double pyad)
        {
            return pyad * Dm;
        }

        public double getSm(double pyad)
        {
            return pyad * Sm;
        }

        public double getMm(double pyad)
        {
            return pyad * Mm;
        }

        public double getVershok(double pyad)
        {
            return pyad * Vershok;
        }

        public double getArshin(double pyad)
        {
            return pyad * Arshin;
        }

        public double getSagen(double pyad)
        {
            return pyad * Sagen;
        }

        public double getInch(double pyad)
        {
            return pyad * Inch;
        }

        public double getFoot(double pyad)
        {
            return pyad * Foot;
        }

        public double getYard(double pyad)
        {
            return pyad * Yard;
        }

        public double getCable(double pyad)
        {
            return pyad * Cable;
        }
    }
}
