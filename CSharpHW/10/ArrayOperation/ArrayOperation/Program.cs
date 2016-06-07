using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Random random = new Random();
            var arrM = new ArrayManagement();
            string choice;
            Console.WriteLine("Программа по управлению массива.");
            Console.WriteLine("У нас есть пустой массив на 5 елементов");
            labelStart:
            Console.WriteLine("Есть три способа его заполнения"+
                "\nВ ручную введите 1 \nАвтоматично числа по порядку введите 2 "+
                "\nАвтоматично случайные числа введите - 3"+
                "\nВыйти ведите q");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    arrM.ManFillArray();
                    break;
                case "2":                
                    arrM.FillArray();
                    break;
                case "3":
                    int min, max;
                    Console.WriteLine("\nВведите минимальный диапазон ");
                    min = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nВведите максимльный диапазон ");
                    max = int.Parse(Console.ReadLine());
                    arrM.fillRandArray(min,max);
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nВы ввели не верно, попробуйте еще раз");
                    goto labelStart;
                    
            }
            labelAction:
            Console.WriteLine("\nВозможные действия \nдобавить элементы - 1\nнайти элемент по индексу -2"+
                "\nпроверить наличие элемента-3"+ "\nВыход q");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nВведите количество добовляемых елементов ");
                    int add = int.Parse(Console.ReadLine());
                    arrM.Add(add);
                    break;
                case "2":
                    int index;
                    Console.WriteLine("\nВведите индекс ");
                    index = int.Parse(Console.ReadLine());
                    arrM.GetByIndex(index);
                    break;
                case "3":                                  
                    int element;
                    Console.WriteLine("\nВведите значение элимена");
                    element = int.Parse(Console.ReadLine());
                    arrM.Contains(element);
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nВы ввели не верно, попробуйте еще раз");
                    goto labelAction;

            }


            Console.WriteLine("\nЕсли хотите вернуться к выбору действию введите y\nЕсли хотите выйти, введите любой символ");
            choice = Console.ReadLine();
            if (choice == "y")
            { goto labelAction; }
            Console.ReadKey();

           

        }
    }


    class ArrayManagement
    {

        private int[] nArray = new int[5];
        Random rnd = new Random();

        public void FillArray()
        {
            for (int i = 0; i < nArray.Length; i++)
            {
                nArray[i] = i;
            }
            ShowArray();
        }
        public void fillRandArray(int min,int max)
        {
            for (int i = 0; i < nArray.Length; i++)
            {
                nArray[i] = rnd.Next(min,max);
            }
            ShowArray();
        }
        public void ManFillArray()
        {
            for (int i = 0; i < nArray.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                nArray[i] = Int32.Parse(Console.ReadLine());
            }
            ShowArray();
        }

        public void Add(int size)
        {
            int lastsize = nArray.Length;
            Array.Resize(ref nArray, nArray.Length + size);
            for (int i = lastsize; i < nArray.Length; i++)
            {
                Console.Write(" Заполните {0} элимент: ", i);
                nArray[i] = Int32.Parse(Console.ReadLine());
            }
            ShowArray();
        }
        public void Contains(int element)
        {
            if (Array.IndexOf(nArray, element) < 0)
            {
                Console.WriteLine("Запрашиваемый вами элимент {0} отсутствует",element);
            }
            else
                Console.WriteLine("Запрашиваемый вами элимент {0} есть в масиве", element);
        }
        public void GetByIndex(int index)
        {
            try
            {
                Console.WriteLine("Елемент по индексу {0} являеться {1}", index, nArray[index]);
            }
            catch
            {
                Console.WriteLine("Увы индекс вне диапазона массива.");
            }

         }
        public void ShowArray()
        {
            Console.WriteLine("\nВаш масив сейчас : ");
            for (int i = 0; i < nArray.Length; i++)
            { Console.Write(nArray[i]+" "); }
        }

    }
}
