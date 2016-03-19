using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    public class Sm
    {
        double Metr = 0.01;
        double Dm = 0.1;
        double Mm = 10;

        public double getMetr(double sm)
        {
            return sm * Metr;
        }

        public double getDm(double sm)
        {
            return sm * Dm;
        }

        public double getMm(double sm)
        {
            return sm * Mm;
        }
    }
}
