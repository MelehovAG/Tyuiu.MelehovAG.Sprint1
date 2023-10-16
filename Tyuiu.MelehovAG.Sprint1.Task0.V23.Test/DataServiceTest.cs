﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MelehovAG.Sprint1.Task0.V23.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(13, res);
        }
    }
}
