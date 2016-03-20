using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Сажень
    public class Sagen
    {
        double M = 2.134;
        double Dm = 21.34;
        double Sm = 213.4;
        double Mm = 2134;
        double Vershok = 48;
        double Pyad = 12;
        double Arshin = 3;
        double Inch = 84;
        double Foot = 7;

        public double getMetr(double sagen)
        {
            return sagen * M;
        }

        public double getVershok(double sagen)
        {
            return sagen * Vershok;
        }

        public double getDm(double sagen)
        {
            return sagen * Dm;
        }

        public double getSm(double sagen)
        {
            return sagen * Sm;
        }

        public double getPyad(double sagen)
        {
            return sagen * Pyad;
        }

        public double getMm(double sagen)
        {
            return sagen * Mm;
        }

        public double getArshin(double sagen)
        {
            return sagen * Arshin;
        }

        public double getInch(double sagen)
        {
            return sagen * Inch;
        }

        public double getFoot(double sagen)
        {
            return sagen * Foot;
        }
    }
}
