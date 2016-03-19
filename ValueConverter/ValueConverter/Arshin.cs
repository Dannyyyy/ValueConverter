using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    public class Arshin
    {
        double Metr = 0.711;
        double Dm = 7.112;
        double Sm = 71.12;
        double Mm = 711.2;
        double Inch = 16;
        double Span = 4;
        double Fathom = 0.333;

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

        public double getInch(double arsh)
        {
            return arsh * Inch;
        }

        public double getSpan(double arsh)
        {
            return arsh * Span;
        }

        public double getFathom(double arsh)
        {
            return arsh * Fathom;
        }
    }
}
