using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MelehovAG.Sprint1.Task6.V13.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "АБВГООДДВЖВО";
            DataService ds = new DataService();
            string res = Convert.ToString(ds.CheckWordsAlphabet(strTest));
            string wait = "False";
            Assert.AreEqual(wait, res);

        }
    }
}
