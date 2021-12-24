namespace Task4
{
    internal class Person
    {
        internal readonly string Name;
        internal readonly string Street;
        internal readonly int HouseNumber;
        internal readonly int FlatNumber;
        internal readonly long MobilePhone;
        internal readonly long HomePhone;

        /// <summary>
        /// Конструктор класса Person
        /// </summary>
        /// <param name="data">Ссылка на PersonData</param>
        public Person(PersonData data)
        {
            Name = data.Name;
            Street = data.Street;
            HouseNumber = data.HouseNumber;
            FlatNumber = data.FlatNumber;
            MobilePhone = data.MobilePhone;
            HomePhone = data.HomePhone;
        }
    }

    public struct PersonData
    {
        public string Name;
        public string Street;
        public int HouseNumber;
        public int FlatNumber;
        public long MobilePhone;
        public long HomePhone;
    }
}