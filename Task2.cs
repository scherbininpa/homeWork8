using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork8
{
    struct Task2
    {
        private Dictionary<string,string> dictionary = new Dictionary<string,string>();
        public Task2()
        {   
        }
        public void FillDictionary()
        {
            bool endData = true;
            while (endData)
            {
                Console.WriteLine("Введите номер телефона:");
                string telepfone =  Console.ReadLine();
                if (telepfone == string.Empty)
                {
                    endData = false;
                }else
                {
                    Console.WriteLine("Введите ФИО:");
                    string name = Console.ReadLine();
                    dictionary.Add(telepfone, name);
                }
            }
            Console.WriteLine($"Заполнение словаря закончено. Всего записей - {dictionary.Count}");
        }

        /// <summary>
        /// Поиск ФИО по номеру телеофна
        /// </summary>
        /// <param name="telepfone">Номер телефона</param>
        public void FindElement(string telepfone)
        {
            string value = "";
            if (dictionary.TryGetValue(telepfone, out value))
            {
                Console.WriteLine($"Под номером {telepfone} записан - {value}");
            }
            else
            {
                Console.WriteLine($"Номер - {telepfone} отсутствует в телефонной книге");
            }
        }
    }
}
