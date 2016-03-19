using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    public class Dm
    {
        double M = 0.1;
        double Sm = 10;
        double Mm = 100;
        double Inch = 2.25;
        double Span = 0.562;

        public double getMetr(double dm)
        {
            return dm * M;
        }

        public double getInch(double dm)
        {
            return dm * Inch;
        }

        public double getSm(double dm)
        {
            return dm * Sm;
        }

        public double getSpan(double dm)
        {
            return dm * Span;
        }

        public double getMm(double dm)
        {
            return dm * Mm;
        }
    }
}
