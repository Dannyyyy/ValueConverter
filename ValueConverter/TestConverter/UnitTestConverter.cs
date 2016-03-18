using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueConverter
{
    [TestClass]
    public class UnitTestConverter
    {
        [TestMethod]
        public void TestMetrSm()
        {
            Metr metr = new Metr();
            double result = metr.getSm(8);
            Assert.AreEqual(result, 800, 0.001, "Ошибка конвертации");
        }

        [TestMethod]
        public void TestSmMetr()
        {
            Sm sm = new Sm();
            double result = sm.getMetr(8);
            Assert.AreEqual(result, 0.08, 0.001, "Ошибка конвертации");
        }
    }
}
