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
        }
    }
}
