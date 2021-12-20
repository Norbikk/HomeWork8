using System;

namespace Task2Notebook
{
    class Program
    {
        private static WorkWithDict _works = new();

        static void Main(string[] args)
        {
            do
            {
                AddPersonDataInput();
                Console.WriteLine("Для выхода нажмите ENTER");
            } while (Console.ReadLine() != String.Empty);

            do
            {
                SearchByInput();
                Console.WriteLine("Повторить поиск? Введите любой символ\nДля выхода нажмите ENTER");
            } while (Console.ReadLine() != String.Empty);
            
        }

        /// <summary>
        /// Добавляет пользователя в Дикшенари с инпута консоли
        /// </summary>
        private static void AddPersonDataInput()
        {
            PersonDataInput();
            _works.PersonsAdd();
        }
        /// <summary>
        /// Поиск пользователя с инпута в консоли
        /// </summary>
        private static void SearchByInput()
        {
            Console.WriteLine("Впишите номер для поиска");
            var key = Convert.ToInt64(Console.ReadLine());
            var s = _works.SearchPerson(key);
            Console.WriteLine(s);
        }

        /// <summary>
        /// Ввод данных с консоли
        /// </summary>
        private static void PersonDataInput()
        {
            Console.WriteLine("Введите номер");
            var number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите имя");
            var name = Console.ReadLine();
            _works.CreatePerson(number, name);

        }

       
    }
}