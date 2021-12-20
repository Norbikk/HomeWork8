using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        private static readonly HashChecker HashChecker = new();

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите число");
                var num = Convert.ToInt32(Console.ReadLine());
                var s = HashChecker.CheckNum(num);
                Console.WriteLine(s);
                Console.WriteLine("Для выхода нажмите ENTER");
            } while (Console.ReadLine() != String.Empty);

            var str = HashChecker.WriteHashSet();
            Console.WriteLine(str);
        }
    }
}