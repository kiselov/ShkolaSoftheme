using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public class ColourPrinter : Printer
    {
        public override void Print(string SomeValue)
        {
            base.Print(SomeValue);
        }
        public void Print(string SomeValue, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(SomeValue);
            Console.ResetColor();

        }
    }
}
