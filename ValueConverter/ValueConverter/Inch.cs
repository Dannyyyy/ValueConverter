using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    public class Inch
    {
        double Metr = 0.0445;
        double Dm = 0.445;
        double Sm = 4.445;
        double Mm = 44.45;
        double Span = 0.25;
        double Arshin = 0.0625;
        double Fathom = 0.0208;

        public double getMetr(double inch)
        {
            return inch * Metr;
        }

        public double getDm(double inch)
        {
            return inch * Dm;
        }

        public double getSpan(double inch)
        {
            return inch * Span;
        }

        public double getSm(double inch)
        {
            return inch * Sm;
        }

        public double getMm(double inch)
        {
            return inch * Mm;
        }

        public double getArshin(double inch)
        {
            return inch * Arshin;
        }

        public double getFathom(double inch)
        {
            return inch * Fathom;
        }
    }
}
