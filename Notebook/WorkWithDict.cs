using System;
using System.Collections.Generic;

namespace Task2Notebook
{
    public struct PersonData
    {
        public long Number;
        public string Name;
    }

    public class WorkWithDict
    {
        private static PersonData _personData;

        private static Dictionary<long, string> _persons = new();

        /// <summary>
        /// Ищет пользователя по номеру телефона
        /// </summary>
        /// <param name="key">Номер</param>
        /// <returns>Возвращает результат</returns>
        public string SearchPerson(long key)
        {
            var result = _persons.TryGetValue(key, out var value)
                ? $"Для номера : {key}, Пользователь: {value}."
                : "Пользователь с данным номером не найден.";

            return result;
        }

        /// <summary>
        /// Добавляет пользователя
        /// </summary>
        public void PersonsAdd()
        {
            _persons.Add(_personData.Number, _personData.Name);
        }

        /// <summary>
        /// Создает пользователя
        /// </summary>
        /// <param name="number">Номер телефона</param>
        /// <param name="name">Имя пользователя</param>
        public void CreatePerson(long number, string name)
        {
            _personData.Number = number;

            _personData.Name = name;
        }
    }
}