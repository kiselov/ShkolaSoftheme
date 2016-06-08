using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue q = new MyQueue();
            q.Push(1);
            q.Push(2);
            q.Push(3);

            Console.WriteLine("{0,-10} - исходная очередь", q);
            Console.WriteLine("{1,-10} - После удаления {0}", q.Pop(), q);
            Console.WriteLine("{1,-10} - После удаления {0}", q.Pop(), q);

            Console.ReadLine();
        }
    }
}
