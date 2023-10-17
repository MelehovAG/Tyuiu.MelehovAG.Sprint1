using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MelehovAG.Sprint1.Task3.V7.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double ans = 2.134;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(ans, res);
        }
    }
}
