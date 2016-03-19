using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    public class Mm
    {
        double Metr = 0.001;
        double Dm = 0.01;
        double Sm = 0.1;

        public double getMetr(double mm)
        {
            return mm * Metr;
        }

        public double getDm(double mm)
        {
            return mm * Dm;
        }

        public double getSm(double mm)
        {
            return mm * Sm;
        }
    }
}
