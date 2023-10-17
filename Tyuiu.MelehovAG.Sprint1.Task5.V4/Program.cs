using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint1.Task5.V4.Lib;

namespace Tyuiu.MelehovAG.Sprint1.Task5.V4
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h) прошло к   *");
            Console.WriteLine("* этому моменту (например, h=3, если k=13257).                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("* Введите число, обозначающее идущую секунду суток: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.SecondsToHours(k));
            Console.WriteLine("* Полных часов согласно введённому значению: " + res);

            Console.ReadLine();
        }
    }
}
