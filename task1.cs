using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork8
{
    struct Task1
    {
        private List<int> list = new List<int>();
        public Task1(int count)
        {
            Random random = new Random();
            for (int i = 1; i < count; i++) list.Add(random.Next(100));   
        }
        /// <summary>
        /// Будут удалены элементы между минимадбным и максимальным значением
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        public void RemoveElementBetween(int minValue, int maxValue)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ( list[i]>minValue && list[i] < maxValue)
                { 
                    list.RemoveAt(i);
                    i--;
                }
            }
        }
        /// <summary>
        /// Вывод данных в консоль
        /// </summary>
        /// <param name="msg">Сообщение перед выводом данных</param>
        public void Print(string msg)
        {
            Console.WriteLine($"{msg}");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write((i == list.Count-1) ? $"{list[i]}" : $"{list[i]},");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
