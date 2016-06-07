using System;
using task11;

namespace task11_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var colourPrinter = new ColourPrinter();
            var photoPrinter = new PhotoPrinter();

            object photo = "Photo2", photo1 = "Photo1";

            Console.WriteLine("Printer");
            printer.PrintSomeArray("Some Text", "Some Text2", "Some Text3");

            Console.WriteLine("------------------");

            Console.WriteLine("Coluor Printer");
            colourPrinter.PrintColorArray(new string[] { "Some text", "Some Text1" }, new ConsoleColor[] { ConsoleColor.Red,ConsoleColor.DarkGreen });

            Console.WriteLine("------------------");

            Console.WriteLine("Photo Printer");
            photoPrinter.PrintPhotoArray(photo,photo1);

            Console.ReadLine();
        }
    }
}
