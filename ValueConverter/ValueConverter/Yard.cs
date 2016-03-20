using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Ярд
    public class Yard
    {
        double M = 0.914;
        double Sm = 91.44;
        double Dm = 9.144;
        double Mm = 914.4;
        double Vershok = 20.57;
        double Pyad = 5.143;
        double Arshin = 1.286;
        double Sagen = 0.429;
        double Inch = 36;
        double Foot = 3;
        double Cable = 0.00494;

        public double getMetr(double yard)
        {
            return yard * M;
        }

        public double getVershok(double yard)
        {
            return yard * Vershok;
        }

        public double getDm(double yard)
        {
            return yard * Dm;
        }

        public double getSm(double yard)
        {
            return yard * Sm;
        }

        public double getPyad(double yard)
        {
            return yard * Pyad;
        }

        public double getMm(double yard)
        {
            return yard * Mm;
        }

        public double getArshin(double yard)
        {
            return yard * Arshin;
        }

        public double getSagen(double yard)
        {
            return yard * Sagen;
        }

        public double getInch(double yard)
        {
            return yard * Inch;
        }

        public double getFoot(double yard)
        {
            return yard * Foot;
        }

        public double getCable(double yard)
        {
            return yard * Cable;
        }
    }
}
