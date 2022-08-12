using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork8
{
    struct Task2
    {
        private Dictionary<long,string> dictionary = new Dictionary<long,string>();
        public Task2()
        { 
        
        }
        public void FillDictionary()
        {
            bool endData = true;
            while (endData)
            {
                Console.WriteLine("Введите номер телефона:");
                long telepfone = long.Parse( Console.ReadLine());
                if (telepfone == 0)
                {
                    endData = false;
                }else
                {
                    Console.WriteLine("Введите ФИО:");
                    string name = Console.ReadLine();
                    dictionary.Add(telepfone, name);
                }
            }
        }
    }
}
