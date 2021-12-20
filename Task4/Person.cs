using System.Collections.Generic;
using System.Xml.Linq;

namespace Task4
{
    struct PersonData
    {
        public string Name;
        public string Street;
        public int HouseNumber;
        public int FlatNumber;
        public long MobilePhone;
        public long HomePhone;
    }

    class XmlWorker
    {
        private  PersonData _members = new PersonData();


        public void PersonToXml()
        {
            XElement personName = new XElement("Person");
            XElement personAdress = new XElement("Adress");
            XElement personStreet = new XElement("Street");
            XElement personHouseNumber = new XElement("HouseNumber");
            XElement personFlatNumber = new XElement("FlatNumber");
            XElement personPhones = new XElement("Phones");
            XElement personMobilePhone = new XElement("MobilePhone");
            XElement personHomePhone = new XElement("FlatPhone");

            XAttribute xAttributeName = new XAttribute("Имя", "0");
            personName.Add(xAttributeName);
            XAttribute xAttributeStreet = new XAttribute("Улица", "0");
            personStreet.Add(xAttributeStreet);
            XAttribute xAttributeHouseNumber = new XAttribute("Номер дома", 0);
            personHouseNumber.Add(xAttributeHouseNumber);
            XAttribute xAttributeFlatNumber = new XAttribute("Номер квартиры", 0);
            personFlatNumber.Add(xAttributeFlatNumber);
            XAttribute xAttributeMobilePhone = new XAttribute("Мобильный телефон", 0);
            personMobilePhone.Add(xAttributeMobilePhone);
            XAttribute xAttributeFlatPhone = new XAttribute("Домашний телефон", 0);
            personHomePhone.Add(xAttributeFlatPhone);

            personAdress.Add(personStreet);
            personStreet.Add(personHouseNumber, personFlatNumber);
            personPhones.Add(personMobilePhone, personHomePhone);
            
            personName.Save("_person.xml");
        }
    }

    class Person
    {
        /*
         * ФИО
         * Улица
         * Номер дома
         * Номер квартиры
         * Мобильный телефон
         * Домашний телефон
         */
        private string _name;
        private string _street;
        private int _houseNumber;
        private int _flatNumber;
        private long _mobilePhone;
        private long _homePhone;

        public Person(PersonData data)
        {
            data.Name = _name;
            data.Street = _street;
            data.FlatNumber = _flatNumber;
            data.HouseNumber = _houseNumber;
            data.HomePhone = _homePhone;
            data.MobilePhone = _mobilePhone;
        }
    }
}