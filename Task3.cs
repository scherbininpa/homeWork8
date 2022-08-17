using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork8
{
    struct Task3
    {
        private HashSet<int> hashSet = new System.Collections.Generic.HashSet<int>();
        public Task3()
        { 
            
        }
        public void AddValues()
        {
            Console.WriteLine("Для выхода нажмите ENTER");
            bool flagRepeat = true;
            while (flagRepeat)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (hashSet.Contains(num)){ Console.WriteLine("Такое число присутствует в коллекции."); }
                    else { 
                        hashSet.Add(num); 
                        Console.WriteLine($"Число {num} добавлено в коллекцию") ; 
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Работа прекращена.");
                    flagRepeat = false;
                }
            }
        }
    }
}
