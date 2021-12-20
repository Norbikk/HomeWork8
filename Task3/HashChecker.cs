using System.Collections.Generic;

namespace Task3
{
    class HashChecker
    {
        private HashSet<int> _nums = new();
        
        /// <summary>
        /// Проверяет числа на добавление, если не было - добавляет
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Возвращает строку</returns>
        public string CheckNum(int num)
        {
            string result;

            if (_nums.Contains(num))
            {
                result = "Число вводилось ранее";
            }
            else
            {
                _nums.Add(num);
                result = $"Число {num} успешно добавлено";
            }

            return result;
        }

        /// <summary>
        /// Сохраняет в строке весь список
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public string WriteHashSet()
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