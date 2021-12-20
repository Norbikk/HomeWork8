using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        
        private static List<int> _nums = new List<int>();
        
        static void Main(string[] args)
        {
            AddRandomNums();
            string s = OutputList();
            Console.WriteLine(s);

            DeleteChosenNumsAndOutput();
            Console.ReadLine();
        }

        
        /// <summary>
        /// Заполняет лист рандомными числами
        /// </summary>
        private static void AddRandomNums()
        {
              Random r = new Random();
             _nums = new List<int>();
            
            for (int i = 0; i < 100; i++)
            {
                _nums.Add(r.Next(0, 100));
            }
        }

        /// <summary>
        /// Удаляет и выводит
        /// </summary>
        private static void DeleteChosenNumsAndOutput()
        {
            DeleteChosenNums();
            var s = OutputList();
            Console.WriteLine(s);

        }
        /// <summary>
        /// Удаляет цифры (25;50)
        /// </summary>
        private static void DeleteChosenNums()
        {
            _nums.RemoveAll(x => x > 25 && x < 50);
        }
        /// <summary>
        /// Выводит лист в строку
        /// </summary>
        /// <returns>Возвращает строку</returns>
        private static string OutputList()
        {
            string result = null;
            
            foreach (var t in _nums)
            {
                result += t + " ";
            }

            return result;
        }
        


    }
}