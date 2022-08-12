using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork8
{
    struct Task1
    {
        public List<int> list = new List<int>();
        public Task1(int count)
        {
            Random random = new Random();
            for (int i = 1; i < count; i++)
            {
                list.Add(random.Next(100));
            }
        }

        public void Print()
        {
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write((i == list.Count-1) ? $"{list[i]}" : $"{list[i]},");
            }
        }
    }
}
