﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    public class Span
    {
        double Metr = 0.178;
        double Dm = 1.778;
        double Sm = 17.78;
        double Mm = 177.8;
        double Inch = 4;
        double Arshin = 0.25;
        double Fathom = 0.0833;

        public double getMetr(double sp)
        {
            return sp * Metr;
        }

        public double getDm(double sp)
        {
            return sp * Dm;
        }

        public double getSm(double sp)
        {
            return sp * Sm;
        }

        public double getMm(double sp)
        {
            return sp * Mm;
        }

        public double getInch(double sp)
        {
            return sp * Inch;
        }

        public double getArshin(double sp)
        {
            return sp * Arshin;
        }

        public double getFathom(double sp)
        {
            return sp * Fathom;
        }
    }
}
