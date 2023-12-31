﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint1.Task0.V23.Lib;

//ЗАДАНИЕ
//Написать программу, которая вычисляет выражение (15/5*4)+1 и печатает результат на экране.
//Название проектов (консольного приложения, библиотеки классов, тестового модуля) оформить по шаблону в соответствии с вариантом. Интерфейс консольного приложения оформить по шаблону. 

namespace Tyuiu.MelehovAG.Sprint1.Task0.V23
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
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (15 / 5 * 4) + 1 и      *");
            Console.WriteLine("* печатает результат на экране.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (15 / 5 * 4) + 1                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.SpirinIS.Sprint1.Task0.V23.Lib
            //в классе DataService

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
