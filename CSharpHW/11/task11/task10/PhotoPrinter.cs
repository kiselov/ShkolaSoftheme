using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string SomeValue)
        {
            base.Print(SomeValue);
        }
        public void Print(object somePhoto)
        {
            Console.WriteLine("Object "+somePhoto);
        }
    }
}
