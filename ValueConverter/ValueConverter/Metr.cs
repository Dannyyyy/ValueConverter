using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    class Metr
    {
        double Sm = 100;

        public double getSm(double m)
        {
            return m * Sm;
        }
    }
}
