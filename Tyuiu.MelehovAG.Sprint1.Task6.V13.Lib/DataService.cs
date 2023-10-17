using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MelehovAG.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            bool isOrdered = IsAlphabeticallyOrdered(value);

            if (isOrdered)
            {
                return true;
                //Console.WriteLine("Буквы в строке упорядочены по алфавиту.");
            }
            else
            {
                return false;
               // Console.WriteLine("Буквы в строке не упорядочены по алфавиту.");
            }
        }
        public bool IsAlphabeticallyOrdered(string input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < input[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
