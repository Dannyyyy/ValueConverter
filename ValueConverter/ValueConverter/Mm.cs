﻿using System;
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
        double Inch = 0.0225;
        double Span = 0.00562;
        double Arshin = 0.00141;
        double Fathom = 0.000469;

        public double getMetr(double mm)
        {
            return mm * Metr;
        }

        public double getSpan(double mm)
        {
            return mm * Span;
        }

        public double getDm(double mm)
        {
            return mm * Dm;
        }

        public double getInch(double mm)
        {
            return mm * Inch;
        }

        public double getSm(double mm)
        {
            return mm * Sm;
        }

        public double getArshin(double mm)
        {
            return mm * Arshin;
        }

        public double getFathom(double mm)
        {
            return mm * Fathom;
        }
    }
}
