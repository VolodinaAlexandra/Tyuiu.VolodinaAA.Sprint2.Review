using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint2.Review.V11.Lib;

namespace Tyuiu.VolodinaAA.Sprint2.Review.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = -0.8;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
