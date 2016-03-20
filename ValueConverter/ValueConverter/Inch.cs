using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Дюйм
    public class Inch
    {
        double Metr = 0.0254;
        double Dm = 0.254;
        double Sm = 2.54;
        double Mm = 25.4;
        double Vershok = 0.571;
        double Pyad = 0.143;
        double Arshin = 0.0357;
        double Sagen = 0.0119;
        double Foot = 0.0833;

        public double getMetr(double inch)
        {
            return inch * Metr;
        }

        public double getPyad(double inch)
        {
            return inch * Pyad;
        }

        public double getDm(double inch)
        {
            return inch * Dm;
        }

        public double getMm(double inch)
        {
            return inch * Mm;
        }

        public double getVershok(double inch)
        {
            return inch * Vershok;
        }

        public double getSm(double inch)
        {
            return inch * Sm;
        }

        public double getArshin(double inch)
        {
            return inch * Arshin;
        }

        public double getSagen(double inch)
        {
            return inch * Sagen;
        }

        public double getFoot(double inch)
        {
            return inch * Foot;
        }
    }
}
