using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueConverter
{
    //Вершок
    public class Vershok
    {
        double Metr = 0.0445;
        double Dm = 0.445;
        double Sm = 4.445;
        double Mm = 44.45;
        double Pyad = 0.25;
        double Arshin = 0.0625;
        double Sagen = 0.0208;
        double Inch = 1.75;
        double Foot = 0.146;

        public double getMetr(double vershok)
        {
            return vershok * Metr;
        }

        public double getDm(double vershok)
        {
            return vershok * Dm;
        }

        public double getPyad(double vershok)
        {
            return vershok * Pyad;
        }

        public double getSm(double vershok)
        {
            return vershok * Sm;
        }

        public double getMm(double vershok)
        {
            return vershok * Mm;
        }

        public double getArshin(double vershok)
        {
            return vershok * Arshin;
        }

        public double getSAgen(double vershok)
        {
            return vershok * Sagen;
        }

        public double getInch(double vershok)
        {
            return vershok * Inch;
        }

        public double getFoot(double vershok)
        {
            return vershok * Foot;
        }
    }
}
