using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MelehovAG.Sprint1.Task2.V30.Lib
{
    public class DataService : ISprint1Task2V30
    {
        public double ConvertKmToMetre(double value)
        {
            return Math.Round(value * 1000, 3);
        }
    }
}
