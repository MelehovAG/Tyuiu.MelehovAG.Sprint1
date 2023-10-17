using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint1.Task7.V0.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Мелехов А.Г. | ПКТб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                             *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                  y - z                                                  *");
            Console.WriteLine("*                 -------                                                 *");
            Console.WriteLine("*                 (y - x)                                                 *");
            Console.WriteLine("* f = (y - x) ----------------                                            *");
            Console.WriteLine("*                          2                                              *");
            Console.WriteLine("*               1 + (y - x)                                               *");
            Console.WriteLine("***************************************************************************");
            double x, y, z;

            Console.Write("* Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("* Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("* Введите значение Z: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* " + ds.Calculate(x, y, z));
            Console.ReadKey();
        }
    }
}
