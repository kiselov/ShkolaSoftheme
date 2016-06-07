using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            var usr = new User("user","1234");
            var usr1 = new User();
            // копирование значимого типа
            string name1 = "Bob";
            string name2 = name1;
            // копирование ссылочного  типа
            usr1 = usr;
           
            

        }
    }
}
