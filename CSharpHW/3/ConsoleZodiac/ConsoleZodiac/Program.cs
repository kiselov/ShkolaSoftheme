using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleZodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            string zodiac;

            try
            {
                Console.WriteLine("Введите день вашего рождения");
                day = int.Parse(Console.ReadLine());
                if (day < 0 || day > 31)
                { throw new Exception(); }

                Console.WriteLine("Введите месяц вашего рождения");
                month = int.Parse(Console.ReadLine());
                switch (month)
                {
                    case 1:
                        if (day <= 20) zodiac = "Козерог";
                        else zodiac = "Водолей";
                        break;
                    case 2:
                        if (day <= 19) zodiac = "Водоелей";
                        else zodiac = "Рыбы";
                        break;
                    case 3:
                        if (day <= 20) zodiac = "Рыбы";
                        else zodiac = "Овен";
                        break;
                    case 4:
                        if (day <= 20) zodiac = " Овен";
                        else zodiac = "Телец";
                        break;
                    case 5:
                        if (day <= 21) zodiac = " Телец";
                        else zodiac = "Близнецы";
                        break;
                    case 6:
                        if (day <= 21) zodiac = " Близнецы";
                        else zodiac = "Рак";
                        break;
                    case 7:
                        if (day <= 23) zodiac = " Рак";
                        else zodiac = "Лев";
                        break;
                    case 8:
                        if (day <= 21) zodiac = "Лев";
                        else zodiac = "Дева";
                        break;
                    case 9:
                        if (day <= 23) zodiac = "Дева";
                        else zodiac = "Весы";
                        break;
                    case 10:
                        if (day <= 23) zodiac = " Весы";
                        else zodiac = "Скорпион";
                        break;
                    case 11:
                        if (day <= 22) zodiac = "Скорпион";
                        else zodiac = "Стрелец";
                        break;
                    case 12:
                        if (day <= 22) zodiac = " Стрелец";
                        else zodiac = "Козерог";
                        break;
                    default:
                        throw new Exception();
                }


                Console.WriteLine("Введите год вашего рождения");
                year = int.Parse(Console.ReadLine());
                if (year < 1900 || year > 2016)
                { throw new Exception(); }



                Console.WriteLine("Дата вашего рождения {0}/{1}/{2}", day, month, year);
                Console.WriteLine("Ваш знак зодиака {0}", zodiac);
            }
            catch {
                Console.WriteLine("Не верно заполненны даные!");
            }

            Console.ReadLine();
        }
    }
}
