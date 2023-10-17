using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MelehovAG.Sprint1.Task4.V10.Lib
{
    public class DataService : ISprint1Task4V10
    {
        public double Calculate(double a)
        {
            //return Math.Round((1 + Math.Cos(a)) / Math.Pow(Math.Sin(a), 2), 3);
            //(1 + Math.Cos(125)) / Math.Pow(Math.Sin(125), 2);
            double sina = Math.Sin(a);
            double result = (1 + Math.Cos(a)) / (sina * sina);
            //double aa = 1 + Math.Cos(a);
            //double bb = Math.Pow(Math.Sin(a), 2);
            //double cc = aa / bb;
            return Math.Round(result, 3);
            //((1 + cos(125))) / (sin ^ (2)125)
        }
    }
}
