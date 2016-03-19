using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    public class Fathom
    {
        double M = 2.134;
        double Dm = 21.34;
        double Sm = 213.4;
        double Mm = 2134;
        double Inch = 48;
        double Span = 12;
        double Arshin = 3;

        public double getMetr(double fath)
        {
            return fath * M;
        }

        public double getInch(double fath)
        {
            return fath * Inch;
        }

        public double getDm(double fath)
        {
            return fath * Dm;
        }

        public double getSm(double fath)
        {
            return fath * Sm;
        }

        public double getSpan(double fath)
        {
            return fath * Span;
        }

        public double getMm(double fath)
        {
            return fath * Mm;
        }

        public double getArshin(double fath)
        {
            return fath * Arshin;
        }
    }
}
