using System;
using task11;

namespace task11_2_
{
   public static class ExtensionClass
    {
        public static void PrintSomeArray(this Printer printer, params string[] array)
        {
            foreach (var str in array)
            { printer.Print(str); }
        }

        public static void PrintColorArray(this ColourPrinter colourPrinter,  string[] array,  ConsoleColor[] color)
        {
          
            for (int i = 0; i< array.Length; i++)
            {
                colourPrinter.Print(array[i], color[i]);
            }
           
        }

        public static void PrintPhotoArray(this PhotoPrinter photoPrinter, params object[] photos)
        {
            foreach (var photo in photos)
            { photoPrinter.Print(photo); }
        }
    }
}

