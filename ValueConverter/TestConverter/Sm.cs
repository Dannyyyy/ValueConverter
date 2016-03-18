using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    class Sm
    {
        double Metr = 0.01;

        public double getMetr(double sm)
        {
            return sm * Metr;
        }
    }
}
