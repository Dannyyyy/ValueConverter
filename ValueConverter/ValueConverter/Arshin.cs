using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Аршин
    public class Arshin
    {
        double Metr = 0.711;
        double Dm = 7.112;
        double Sm = 71.12;
        double Mm = 711.2;
        double Vershok = 16;
        double Pyad = 4;
        double Sagen = 0.333;
        double Inch = 28;
        double Foot = 2.333;

        public double getMetr(double arsh)
        {
            return arsh * Metr;
        }

        public double getDm(double arsh)
        {
            return arsh * Dm;
        }

        public double getSm(double arsh)
        {
            return arsh * Sm;
        }

        public double getMm(double arsh)
        {
            return arsh * Mm;
        }

        public double getVershok(double arsh)
        {
            return arsh * Vershok;
        }

        public double getPyad(double arsh)
        {
            return arsh * Pyad;
        }

        public double getSagen(double arsh)
        {
            return arsh * Sagen;
        }

        public double getInch(double arsh)
        {
            return arsh * Inch;
        }

        public double getFoot(double arsh)
        {
            return arsh * Foot;
        }
    }
}
