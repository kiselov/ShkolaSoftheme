using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var colourPrinter = new ColourPrinter();
            var photoPrinter = new PhotoPrinter();
            object photo="photo";
            Console.WriteLine("Printer");
            printer.Print("Some Text");

            Console.WriteLine("------------------");

            Console.WriteLine("Coluor Printer");
            colourPrinter.Print("Some Text", ConsoleColor.Red);

            Console.WriteLine("------------------");

            Console.WriteLine("Photo Printer");
            photoPrinter.Print(photo);

            Console.ReadLine();
        }
    }
}
