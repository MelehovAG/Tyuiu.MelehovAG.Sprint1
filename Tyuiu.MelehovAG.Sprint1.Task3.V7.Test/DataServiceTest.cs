﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            double x = 2.5;
            var res = ds.ConvertKmToMetre(x);
            Assert.AreEqual(2500, res);
        }
    }
}
