﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MelehovAG.Sprint1.Task1.V22.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6, res);

        }
    }
}
