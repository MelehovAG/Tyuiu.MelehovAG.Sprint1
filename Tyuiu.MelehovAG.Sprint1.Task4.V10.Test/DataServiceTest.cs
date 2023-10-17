using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MelehovAG.Sprint1.Task4.V10.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 125;
            double wait = 4.711;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
