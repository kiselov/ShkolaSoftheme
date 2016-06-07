using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;
            string action;

            Console.WriteLine("Добро пожаловать в калькулятор");
            Console.WriteLine("Инструкция по применению: ");

            Console.WriteLine("Введите первое число(для подтверждения нажмите клавишу 'enter')," +
                 "\nзатем введите второе число(для подтверждения нажмите клавишу 'enter')." +
                "\nДальше введите необходимое математическое действие(для подтверждения нажмите клавишу 'enter')," +
                "\nПосле всех правильно выполненных вышeуказанных действий вы получите результат");

            Console.WriteLine("Bозможные математические действие: \n 1. Cложение - символ '+';" +
                "\n 2.  Вычитание - символ '-'; \n 3. Умножение - символ '*';" +
                "\n 4. Деление - символ '/'; ");



            Console.WriteLine();

            try
            {
                Console.Write("Введите первое число: ");
                firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                secondNumber = double.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Ошибка. Неверно введены данные!");
                Console.WriteLine("Перезапустите программу! ");
            }

            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine("Результат: {0:0.00}", result);
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine("Результат: {0:0.00}", result);
                    break;
                case "*":

                    result = firstNumber * secondNumber;
                    Console.WriteLine("Результат: {0:0.00}", result);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Ошибка. На ноль делить не можно!");
                        Console.WriteLine("Перезапустите программу! ");

                        break;
                    }
                    result = firstNumber / secondNumber;
                    Console.WriteLine("Результат: {0:0.00}", result);

                    break;
                default:
                    Console.WriteLine("Не верно выбрано действие");
                    break;



            }
           
                
            

                Console.ReadLine();

        }
    }
}
