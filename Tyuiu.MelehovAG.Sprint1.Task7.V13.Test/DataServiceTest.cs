using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MelehovAG.Sprint1.Task7.V13.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 0.685;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
