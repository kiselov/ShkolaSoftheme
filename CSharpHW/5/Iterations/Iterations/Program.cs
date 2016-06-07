using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int figureNumber;
            int height;
            int weight;
            Console.WriteLine("Выбирите фигуру.");
            Console.WriteLine("Триугольник - 1\nПрямоугольник -2\nРомб - 3");
            figureNumber = Int32.Parse(Console.ReadLine());

            switch (figureNumber)
            {
                case 1:
                    Console.WriteLine("Вы выбрали триугольник.");
                    Console.WriteLine("Введите высоту: ");
                    height = Int32.Parse(Console.ReadLine());
                    Triangle(height);
                    break;

                case 2:
                    Console.WriteLine("Вы выбрали прямоугольник.");
                    Console.WriteLine("Введите высоту: ");
                    height = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите шырину: ");
                    weight = Int32.Parse(Console.ReadLine());
                    Square(height, weight);
                    break;

                case 3:
                    Console.WriteLine("Вы выбрали ромб.");
                    Console.WriteLine("Введите высоту: ");
                    height = Int32.Parse(Console.ReadLine());
                    Rhomb(height);
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }

            
            Console.ReadLine();
        }  

         static void Triangle(int height)
        {
            string star= null;
            Console.WriteLine("Вот ваш триугольник высотой {0}\n", height);

            for (int i = 0; i < height; i++)
            {
                star += "*";
                Console.WriteLine(star);
            }
        }

        static void Rhomb(int height)
        {
            
            int stars;
            height = height % 2 == 0 ? height + 1 : height;
            Console.WriteLine("Вот ваш ромб высотой {0}\n", height);
            for (int i = 0; i < height; i++)
            {
                int spacesBefore = Math.Abs(height / 2 - i);
                stars = (height - 2 * spacesBefore);
                Console.WriteLine("{0}{1}", new string(' ', spacesBefore), new string('*', stars));
            }
            Console.WriteLine();

        }

        static void Square(int height, int weight)
        {
            string star = null;
            Console.WriteLine("Вот ваш квадрат высотой {0}, шыриной {1}\n", height,weight);
            for (int j = 0; j < weight; j++)
            {
                star += "*";
                
            }
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(star);
            }
        }


        }
    }

