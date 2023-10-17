using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MelehovAG.Sprint1.Task5.V4.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x = 3600;
            int d = Convert.ToInt32(x);
            DataService ds = new DataService();
            int res = ds.SecondsToHours(d);

            int result = Convert.ToInt32(res);

            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}
