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

        public double getMetr(double dm)
        {
            return dm * M;
        }

        public double getSm(double dm)
        {
            return dm * Sm;
        }

        public double getMm(double dm)
        {
            return dm * Mm;
        }
    }
}
