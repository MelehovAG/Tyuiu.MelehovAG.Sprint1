using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MelehovAG.Sprint1.Task1.V22.Lib
{
    public class DataService : ISprint1Task1V22
    {
        public double Calculate(double x, double y)
        {
            if (x == 0)
            {
                Console.WriteLine("Переменная x = {0}!!! На ноль делить нельзя.");
                return -1;
            }
            else
            {
                if (y == 0)
                {
                    Console.WriteLine("Переменная y = {0}!!! На ноль делить нельзя.");
                    return -1;
                }
                else
                {
                    double result = (5 + x) / (y * x);
                    return result;
                }
            }
        }
    }
}
