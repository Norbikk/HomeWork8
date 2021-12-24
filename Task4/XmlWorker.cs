using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Task4
{
    internal class XmlWorker
    {
        /// <summary>
        /// Добавляет Person'ов по инпуту
        /// </summary>
        /// <param name="persons">Лист Person'ов</param>
        public void AddPersons(List<Person> persons)
        {
            var person = PersonDataInput();
            persons.Add(new Person(person));
        }

        /// <summary>
        /// Создает XML со списком Person'ов
        /// </summary>
        /// <param name="persons">Лист Person'ов</param>
        /// <param name="path">Путь к файлу</param>
        public void PersonToXml(List<Person> persons, string path)
        {
            XElement xElementPerson = new XElement("List");

            foreach (var t in persons)
            {
                XElement xElementName = new XElement("Person");
                XElement xElementAdress = new XElement("Adress");
                XElement xElementPhones = new XElement("Phones");
                XElement xElementStreet = new XElement("Street", t.Street);
                XElement xElementHouseNum = new XElement("HouseNumber", t.HouseNumber);
                XElement xElementFlatNum = new XElement("FlatNumber", t.FlatNumber);

                XElement xElementMobilePhone = new XElement("MobilePhone", t.MobilePhone);
                XElement xElementFlatPhone = new XElement("FlatPhone", t.HomePhone);

                XAttribute xAttributeName = new XAttribute("name", t.Name);

                xElementName.Add(xElementAdress, xElementPhones, xAttributeName);
                xElementAdress.Add(xElementStreet, xElementHouseNum, xElementFlatNum);
                xElementPhones.Add(xElementMobilePhone, xElementFlatPhone);
                xElementPerson.Add(xElementName);
            }

            xElementPerson.Save(path);
        }

        /// <summary>
        /// Инпут с консоли
        /// </summary>
        /// <returns>Возвращает данные в PersonData</returns>
        private PersonData PersonDataInput()
        {
            var person = new PersonData();
            Console.WriteLine("Введите ФИО");
            person.Name = Console.ReadLine();
            Console.WriteLine("Введите название улицы");
            person.Street = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            person.HouseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер квартиры");
            person.FlatNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер мобильного телефона");
            person.MobilePhone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите домашний телефон");
            person.HomePhone = Convert.ToInt64(Console.ReadLine());

            return person;
        }
    }
}