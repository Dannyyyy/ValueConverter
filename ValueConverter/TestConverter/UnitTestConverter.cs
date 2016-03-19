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
            result = metr.getInch(8);
            Assert.AreEqual(result, 180, 0.001, "Ошибка конвертации");
            result = metr.getSpan(8);
            Assert.AreEqual(result, 44.992, 0.001, "Ошибка конвертации");
            result = metr.getArshin(8);
            Assert.AreEqual(result, 11.248, 0.001, "Ошибка конвертации");
            result = metr.getFathom(8);
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
            result = dm.getInch(8);
            Assert.AreEqual(result, 18, 0.001, "Ошибка конвертации");
            result = dm.getSpan(8);
            Assert.AreEqual(result, 4.496, 0.001, "Ошибка конвертации");
            result = dm.getArshin(8);
            Assert.AreEqual(result, 1.128, 0.001, "Ошибка конвертации");
            result = dm.getFathom(8);
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
            result = sm.getInch(8);
            Assert.AreEqual(result, 1.8, 0.001, "Ошибка конвертации");
            result = sm.getSpan(8);
            Assert.AreEqual(result, 0.4496, 0.001, "Ошибка конвертации");
            result = sm.getArshin(8);
            Assert.AreEqual(result, 0.1128, 0.001, "Ошибка конвертации");
            result = sm.getFathom(8);
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
            result = mm.getInch(8);
            Assert.AreEqual(result, 0.18, 0.001, "Ошибка конвертации");
            result = mm.getSpan(8);
            Assert.AreEqual(result, 0.04496, 0.001, "Ошибка конвертации");
            result = mm.getArshin(8);
            Assert.AreEqual(result, 0.01128, 0.001, "Ошибка конвертации");
            result = mm.getFathom(8);
            Assert.AreEqual(result, 0.003752, 0.001, "Ошибка конвертации");
        }

        //------Вершки---------//
        //Тестирование конвертации вершков
        [TestMethod]
        public void TestInch()
        {
            Inch inch = new Inch();
            double result = inch.getMetr(10);
            Assert.AreEqual(result, 0.445, 0.001, "Ошибка конвертации");
            result = inch.getDm(10);
            Assert.AreEqual(result, 4.45, 0.001, "Ошибка конвертации");
            result = inch.getSm(10);
            Assert.AreEqual(result, 44.45, 0.001, "Ошибка конвертации");
            result = inch.getMm(10);
            Assert.AreEqual(result, 444.5, 0.001, "Ошибка конвертации");
            result = inch.getSpan(10);
            Assert.AreEqual(result, 2.5, 0.001, "Ошибка конвертации");
            result = inch.getArshin(10);
            Assert.AreEqual(result, 0.625, 0.001, "Ошибка конвертации");
            result = inch.getFathom(10);
            Assert.AreEqual(result, 0.208, 0.001, "Ошибка конвертации");
        }

        //------Пяди---------//
        //Тестирование конвертации пядей
        [TestMethod]
        public void TestSpan()
        {
            Span span = new Span();
            double result = span.getMetr(13);
            Assert.AreEqual(result, 2.314, 0.001, "Ошибка конвертации");
            result = span.getDm(13);
            Assert.AreEqual(result, 23.114, 0.001, "Ошибка конвертации");
            result = span.getSm(13);
            Assert.AreEqual(result, 231.14, 0.001, "Ошибка конвертации");
            result = span.getMm(13);
            Assert.AreEqual(result, 2311.4, 0.001, "Ошибка конвертации");
            result = span.getInch(13);
            Assert.AreEqual(result, 52, 0.001, "Ошибка конвертации");
            result = span.getArshin(13);
            Assert.AreEqual(result, 3.25, 0.001, "Ошибка конвертации");
            result = span.getFathom(13);
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
            result = arshin.getInch(5);
            Assert.AreEqual(result, 80, 0.001, "Ошибка конвертации");
            result = arshin.getSpan(5);
            Assert.AreEqual(result, 20, 0.001, "Ошибка конвертации");
            result = arshin.getFathom(5);
            Assert.AreEqual(result, 1.665, 0.001, "Ошибка конвертации");
        }

        //------Сажени---------//
        //Тестирование конвертации аршин
        [TestMethod]
        public void TestFathom()
        {
            Fathom fathom = new Fathom();
            double result = fathom.getMetr(6);
            Assert.AreEqual(result, 12.804, 0.001, "Ошибка конвертации");
            result = fathom.getDm(6);
            Assert.AreEqual(result, 128.04, 0.001, "Ошибка конвертации");
            result = fathom.getSm(6);
            Assert.AreEqual(result, 1280.4, 0.001, "Ошибка конвертации");
            result = fathom.getMm(6);
            Assert.AreEqual(result, 12804, 0.001, "Ошибка конвертации");
            result = fathom.getInch(6);
            Assert.AreEqual(result, 288, 0.001, "Ошибка конвертации");
            result = fathom.getSpan(6);
            Assert.AreEqual(result, 72, 0.001, "Ошибка конвертации");
            result = fathom.getArshin(6);
            Assert.AreEqual(result, 18, 0.001, "Ошибка конвертации");
        }
    }
}
