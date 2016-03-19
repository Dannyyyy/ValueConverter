using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    public class Metr
    {
        double Dm = 10;
        double Sm = 100;
        double Mm = 1000;

        public double getDm(double m)
        {
            return m * Dm;
        }

        public double getSm(double m)
        {
            return m * Sm;
        }

        public double getMm(double m)
        {
            return m * Mm;
        }
    }
}
