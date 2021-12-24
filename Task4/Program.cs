using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        private static readonly XmlWorker XmlWorker = new();

        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            do
            {
                XmlWorker.AddPersons(persons);
                Console.WriteLine("Для выхода нажмите ENTER");
            } while (Console.ReadLine() != String.Empty);

            XmlWorker.PersonToXml(persons, "db.xml");
        }
    }
}