using System;

namespace Task4
{
    class Program
    {
        private  static XmlWorker _xmlWorker = new XmlWorker();
        static void Main(string[] args)
        {
            _xmlWorker.PersonToXml();
        }
    }
}