using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueConverter;

namespace ValueConverter
{
    [TestClass]
    public class UnitTestConverter
    {
        //------Метры---------//
        //Тестирование конвертации метров
        [TestMethod]
        public void TestMetr()
        {
            Metr metr = new Metr();
            double result = metr.getDm(8);
            Assert.AreEqual(result, 80, 0.001, "Ошибка конвертации");
            result = metr.getSm(8);
            Assert.AreEqual(result, 800, 0.001, "Ошибка конвертации");
            result = metr.getMm(8);
            Assert.AreEqual(result, 8000, 0.001, "Ошибка конвертации");
            result = metr.getVershok(8);
            Assert.AreEqual(result, 180, 0.001, "Ошибка конвертации");
            result = metr.getPyad(8);
            Assert.AreEqual(result, 44.992, 0.001, "Ошибка конвертации");
            result = metr.getArshin(8);
            Assert.AreEqual(result, 11.248, 0.001, "Ошибка конвертации");
            result = metr.getSagen(8);
            Assert.AreEqual(result, 3.752, 0.001, "Ошибка конвертации");
        }

        //------Дециметры---------//
        //Тестирование конвертации дециметров
        [TestMethod]
        public void TestDm()
        {
            Dm dm = new Dm();
            double result = dm.getMetr(8);
            Assert.AreEqual(result, 0.8, 0.001, "Ошибка конвертации");
            result = dm.getSm(8);
            Assert.AreEqual(result, 80, 0.001, "Ошибка конвертации");
            result = dm.getMm(8);
            Assert.AreEqual(result, 800, 0.001, "Ошибка конвертации");
            result = dm.getVershok(8);
            Assert.AreEqual(result, 18, 0.001, "Ошибка конвертации");
            result = dm.getPyad(8);
            Assert.AreEqual(result, 4.496, 0.001, "Ошибка конвертации");
            result = dm.getArshin(8);
            Assert.AreEqual(result, 1.128, 0.001, "Ошибка конвертации");
            result = dm.getSagen(8);
            Assert.AreEqual(result, 0.3752, 0.001, "Ошибка конвертации");
        }

        //------Сантиметры---------//
        //Тестирование конвертации сантиметров
        [TestMethod]
        public void TestSm()
        {
            Sm sm = new Sm();
            double result = sm.getMetr(8);
            Assert.AreEqual(result, 0.08, 0.001, "Ошибка конвертации");
            result = sm.getDm(8);
            Assert.AreEqual(result, 0.8, 0.001, "Ошибка конвертации");
            result = sm.getMm(8);
            Assert.AreEqual(result, 80, 0.001, "Ошибка конвертации");
            result = sm.getVershok(8);
            Assert.AreEqual(result, 1.8, 0.001, "Ошибка конвертации");
            result = sm.getPyad(8);
            Assert.AreEqual(result, 0.4496, 0.001, "Ошибка конвертации");
            result = sm.getArshin(8);
            Assert.AreEqual(result, 0.1128, 0.001, "Ошибка конвертации");
            result = sm.getSagen(8);
            Assert.AreEqual(result, 0.03752, 0.001, "Ошибка конвертации");
        }

        //------Миллиметры---------//
        //Тестирование конвертации миллиметров
        [TestMethod]
        public void TestMm()
        {
            Mm mm = new Mm();
            double result = mm.getMetr(8);
            Assert.AreEqual(result, 0.008, 0.001, "Ошибка конвертации");
            result = mm.getDm(8);
            Assert.AreEqual(result, 0.08, 0.001, "Ошибка конвертации");
            result = mm.getSm(8);
            Assert.AreEqual(result, 0.8, 0.001, "Ошибка конвертации");
            result = mm.getVershok(8);
            Assert.AreEqual(result, 0.18, 0.001, "Ошибка конвертации");
            result = mm.getPyad(8);
            Assert.AreEqual(result, 0.04496, 0.001, "Ошибка конвертации");
            result = mm.getArshin(8);
            Assert.AreEqual(result, 0.01128, 0.001, "Ошибка конвертации");
            result = mm.getSagen(8);
            Assert.AreEqual(result, 0.003752, 0.001, "Ошибка конвертации");
        }

        //------Вершки---------//
        //Тестирование конвертации вершков
        [TestMethod]
        public void TestVershok()
        {
            Vershok vershok = new Vershok();
            double result = vershok.getMetr(10);
            Assert.AreEqual(result, 0.445, 0.001, "Ошибка конвертации");
            result = vershok.getDm(10);
            Assert.AreEqual(result, 4.45, 0.001, "Ошибка конвертации");
            result = vershok.getSm(10);
            Assert.AreEqual(result, 44.45, 0.001, "Ошибка конвертации");
            result = vershok.getMm(10);
            Assert.AreEqual(result, 444.5, 0.001, "Ошибка конвертации");
            result = vershok.getPyad(10);
            Assert.AreEqual(result, 2.5, 0.001, "Ошибка конвертации");
            result = vershok.getArshin(10);
            Assert.AreEqual(result, 0.625, 0.001, "Ошибка конвертации");
            result = vershok.getSAgen(10);
            Assert.AreEqual(result, 0.208, 0.001, "Ошибка конвертации");
        }

        //------Пяди---------//
        //Тестирование конвертации пядь
        [TestMethod]
        public void TestPyad()
        {
            Pyad pyad = new Pyad();
            double result = pyad.getMetr(13);
            Assert.AreEqual(result, 2.314, 0.001, "Ошибка конвертации");
            result = pyad.getDm(13);
            Assert.AreEqual(result, 23.114, 0.001, "Ошибка конвертации");
            result = pyad.getSm(13);
            Assert.AreEqual(result, 231.14, 0.001, "Ошибка конвертации");
            result = pyad.getMm(13);
            Assert.AreEqual(result, 2311.4, 0.001, "Ошибка конвертации");
            result = pyad.getVershok(13);
            Assert.AreEqual(result, 52, 0.001, "Ошибка конвертации");
            result = pyad.getArshin(13);
            Assert.AreEqual(result, 3.25, 0.001, "Ошибка конвертации");
            result = pyad.getSagen(13);
            Assert.AreEqual(result, 1.0829, 0.001, "Ошибка конвертации");
        }

        //------Аршины---------//
        //Тестирование конвертации аршин
        [TestMethod]
        public void TestArshin()
        {
            Arshin arshin = new Arshin();
            double result = arshin.getMetr(5);
            Assert.AreEqual(result, 3.555, 0.001, "Ошибка конвертации");
            result = arshin.getDm(5);
            Assert.AreEqual(result, 35.56, 0.001, "Ошибка конвертации");
            result = arshin.getSm(5);
            Assert.AreEqual(result, 355.6, 0.001, "Ошибка конвертации");
            result = arshin.getMm(5);
            Assert.AreEqual(result, 3556, 0.001, "Ошибка конвертации");
            result = arshin.getVershok(5);
            Assert.AreEqual(result, 80, 0.001, "Ошибка конвертации");
            result = arshin.getPyad(5);
            Assert.AreEqual(result, 20, 0.001, "Ошибка конвертации");
            result = arshin.getSagen(5);
            Assert.AreEqual(result, 1.665, 0.001, "Ошибка конвертации");
        }

        //------Сажени---------//
        //Тестирование конвертации сажень
        [TestMethod]
        public void TestSagen()
        {
            Sagen sagen = new Sagen();
            double result = sagen.getMetr(6);
            Assert.AreEqual(result, 12.804, 0.001, "Ошибка конвертации");
            result = sagen.getDm(6);
            Assert.AreEqual(result, 128.04, 0.001, "Ошибка конвертации");
            result = sagen.getSm(6);
            Assert.AreEqual(result, 1280.4, 0.001, "Ошибка конвертации");
            result = sagen.getMm(6);
            Assert.AreEqual(result, 12804, 0.001, "Ошибка конвертации");
            result = sagen.getVershok(6);
            Assert.AreEqual(result, 288, 0.001, "Ошибка конвертации");
            result = sagen.getPyad(6);
            Assert.AreEqual(result, 72, 0.001, "Ошибка конвертации");
            result = sagen.getArshin(6);
            Assert.AreEqual(result, 18, 0.001, "Ошибка конвертации");
        }

        //------Дюймы---------//
        //Тестирование конвертации дюйм
        [TestMethod]
        public void TestInch()
        {
            Inch inch = new Inch();
            double result = inch.getMetr(10);
            Assert.AreEqual(result, 0.254, 0.001, "Ошибка конвертации");
            result = inch.getDm(10);
            Assert.AreEqual(result, 2.54, 0.001, "Ошибка конвертации");
            result = inch.getSm(10);
            Assert.AreEqual(result, 25.4, 0.001, "Ошибка конвертации");
            result = inch.getMm(10);
            Assert.AreEqual(result, 254, 0.001, "Ошибка конвертации");
            result = inch.getVershok(10);
            Assert.AreEqual(result, 5.71, 0.001, "Ошибка конвертации");
            result = inch.getPyad(10);
            Assert.AreEqual(result, 1.43, 0.001, "Ошибка конвертации");
            result = inch.getArshin(10);
            Assert.AreEqual(result, 0.357, 0.001, "Ошибка конвертации");
            result = inch.getSagen(10);
            Assert.AreEqual(result, 0.119, 0.001, "Ошибка конвертации");
            result = inch.getFoot(10);
            Assert.AreEqual(result, 0.833, 0.001, "Ошибка конвертации");
        }

        //------Футы---------//
        //Тестирование конвертации фут
        [TestMethod]
        public void TestFoot()
        {
            Foot ft = new Foot();
            double result = ft.getMetr(10);
            Assert.AreEqual(result, 3.05, 0.001, "Ошибка конвертации");
            result = ft.getDm(10);
            Assert.AreEqual(result, 30.48, 0.001, "Ошибка конвертации");
            result = ft.getSm(10);
            Assert.AreEqual(result, 304.8, 0.001, "Ошибка конвертации");
            result = ft.getMm(10);
            Assert.AreEqual(result, 3048, 0.001, "Ошибка конвертации");
            result = ft.getVershok(10);
            Assert.AreEqual(result, 68.57, 0.001, "Ошибка конвертации");
            result = ft.getPyad(10);
            Assert.AreEqual(result, 17.14, 0.001, "Ошибка конвертации");
            result = ft.getArshin(10);
            Assert.AreEqual(result, 4.29, 0.001, "Ошибка конвертации");
            result = ft.getSagen(10);
            Assert.AreEqual(result, 1.43, 0.001, "Ошибка конвертации");
            result = ft.getInch(10);
            Assert.AreEqual(result, 120, 0.001, "Ошибка конвертации");
        }

        //------Ярды---------//
        //Тестирование конвертации ярд
        [TestMethod]
        public void TestYard()
        {
            Yard yard = new Yard();
            double result = yard.getMetr(7);
            Assert.AreEqual(result, 6.398, 0.001, "Ошибка конвертации");
            result = yard.getDm(7);
            Assert.AreEqual(result, 64.008, 0.001, "Ошибка конвертации");
            result = yard.getSm(7);
            Assert.AreEqual(result, 640.08, 0.001, "Ошибка конвертации");
            result = yard.getMm(7);
            Assert.AreEqual(result, 6400.8, 0.001, "Ошибка конвертации");
            result = yard.getVershok(7);
            Assert.AreEqual(result, 143.99, 0.001, "Ошибка конвертации");
            result = yard.getPyad(7);
            Assert.AreEqual(result, 36, 0.001, "Ошибка конвертации");
            result = yard.getArshin(7);
            Assert.AreEqual(result, 9.002, 0.001, "Ошибка конвертации");
            result = yard.getSagen(7);
            Assert.AreEqual(result, 3.003, 0.001, "Ошибка конвертации");
            result = yard.getInch(7);
            Assert.AreEqual(result, 252, 0.001, "Ошибка конвертации");
            result = yard.getFoot(7);
            Assert.AreEqual(result, 21, 0.001, "Ошибка конвертации");
            result = yard.getCable(7);
            Assert.AreEqual(result, 0.03458, 0.001, "Ошибка конвертации");
        }

        //------Кабельтов---------//
        //Тестирование конвертации кабельтов
        [TestMethod]
        public void TestCable()
        {
            Cable cable = new Cable();
            double result = cable.getMetr(7);
            Assert.AreEqual(result, 1296.4, 0.001, "Ошибка конвертации");
            result = cable.getDm(7);
            Assert.AreEqual(result, 12964, 0.001, "Ошибка конвертации");
            result = cable.getSm(7);
            Assert.AreEqual(result, 129640, 0.001, "Ошибка конвертации");
            result = cable.getMm(7);
            Assert.AreEqual(result, 1296400, 0.001, "Ошибка конвертации");
            result = cable.getVershok(7);
            Assert.AreEqual(result, 29162, 0.001, "Ошибка конвертации");
            result = cable.getPyad(7);
            Assert.AreEqual(result, 7294, 0.001, "Ошибка конвертации");
            result = cable.getArshin(7);
            Assert.AreEqual(result, 1822.8, 0.001, "Ошибка конвертации");
            result = cable.getSagen(7);
            Assert.AreEqual(result, 607.6, 0.001, "Ошибка конвертации");
            result = cable.getInch(7);
            Assert.AreEqual(result, 51037, 0.001, "Ошибка конвертации");
            result = cable.getFoot(7);
            Assert.AreEqual(result, 4253.2, 0.001, "Ошибка конвертации");
            result = cable.getYard(7);
            Assert.AreEqual(result, 1417.5, 0.001, "Ошибка конвертации");
        }
    }
}
