using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Миллиметр
    public class Mm
    {
        double Metr = 0.001;
        double Dm = 0.01;
        double Sm = 0.1;
        double Vershok = 0.0225;
        double Pyad = 0.00562;
        double Arshin = 0.00141;
        double Sagen = 0.000469;
        double Inch = 0.0394;
        double Foot = 0.00328;
        double Yard = 0.00109;
        double Cable = 0.0000054;

        public double getMetr(double mm)
        {
            return mm * Metr;
        }

        public double getPyad(double mm)
        {
            return mm * Pyad;
        }

        public double getDm(double mm)
        {
            return mm * Dm;
        }

        public double getVershok(double mm)
        {
            return mm * Vershok;
        }

        public double getSm(double mm)
        {
            return mm * Sm;
        }

        public double getArshin(double mm)
        {
            return mm * Arshin;
        }

        public double getSagen(double mm)
        {
            return mm * Sagen;
        }

        public double getInch(double mm)
        {
            return mm * Inch;
        }

        public double getFoot(double mm)
        {
            return mm * Foot;
        }

        public double getYard(double mm)
        {
            return mm * Yard;
        }

        public double getCable(double mm)
        {
            return mm * Cable;
        }
    }
}
