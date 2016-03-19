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
        //Тестирование конвертации метров в дециметры
        [TestMethod]
        public void TestMetrDm()
        {
            Metr metr = new Metr();
            double result = metr.getDm(8);
            Assert.AreEqual(result, 80, 0.001, "Ошибка конвертации");
        }

        //Тестирование конвертации метров в сантиметры
        [TestMethod]
        public void TestMetrSm()
        {
            Metr metr = new Metr();
            double result = metr.getSm(8);
            Assert.AreEqual(result, 800, 0.001, "Ошибка конвертации");
        }

        //Тестирование конвертации метров в миллиметры
        [TestMethod]
        public void TestMetrMm()
        {
            Metr metr = new Metr();
            double result = metr.getMm(8);
            Assert.AreEqual(result, 8000, 0.001, "Ошибка конвертации");
        }

        //------Дециметры---------//
        //Тестирование конвертации дециметров в метры
        [TestMethod]
        public void TestDmMetr()
        {
            Dm dm = new Dm();
            double result = dm.getMetr(8);
            Assert.AreEqual(result, 0.8, 0.001, "Ошибка конвертации");
        }

        //Тестирование конвертации дециметров в сантиметры
        [TestMethod]
        public void TestDmSm()
        {
            Dm dm = new Dm();
            double result = dm.getSm(8);
            Assert.AreEqual(result, 80, 0.001, "Ошибка конвертации");
        }

        //Тестирование конвертации дециметров в миллиметры
        [TestMethod]
        public void TestDmMm()
        {
            Dm dm = new Dm();
            double result = dm.getMm(8);
            Assert.AreEqual(result, 800, 0.001, "Ошибка конвертации");
        }

        //------Сантиметры---------//
        //Тестирование конвертации сантиметров в метры
        [TestMethod]
        public void TestSmMetr()
        {
            Sm sm = new Sm();
            double result = sm.getMetr(8);
            Assert.AreEqual(result, 0.08, 0.001, "Ошибка конвертации");
        }

        //Тестирование конвертации сантиметров в дециметры
        [TestMethod]
        public void TestSmDm()
        {
            Sm sm = new Sm();
            double result = sm.getDm(8);
            Assert.AreEqual(result, 0.8, 0.001, "Ошибка конвертации");
        }

        //Тестирование конвертации сантиметров в миллиметры
        [TestMethod]
        public void TestSmMm()
        {
            Sm sm = new Sm();
            double result = sm.getMm(8);
            Assert.AreEqual(result, 80, 0.001, "Ошибка конвертации");
        }

        //------Миллиметры---------//
        //Тестирование конвертации миллиметров в метры
        [TestMethod]
        public void TestMmMetr()
        {
            Mm mm = new Mm();
            double result = mm.getMetr(8);
            Assert.AreEqual(result, 0.008, 0.001, "Ошибка конвертации");
        }
        
        //Тестирование конвертации миллиметров в дециметры
        [TestMethod]
        public void TestMmDm()
        {
            Mm mm = new Mm();
            double result = mm.getDm(8);
            Assert.AreEqual(result, 0.08, 0.001, "Ошибка конвертации");
        }

        //Тестирование конвертации миллиметров в сантиметры
        [TestMethod]
        public void TestMmSm()
        {
            Mm mm = new Mm();
            double result = mm.getSm(8);
            Assert.AreEqual(result, 0.8, 0.001, "Ошибка конвертации");
        }
    }
}
