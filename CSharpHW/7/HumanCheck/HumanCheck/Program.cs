using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanCheck
{
    class Program
    {
        DateTime now = DateTime.Today;
        static void Main(string[] args)
        {

            Console.WriteLine("Cейчас выводит конструктор по умолчанию.Экземпляр human1 ");
            var human1 = new Human();
            Console.WriteLine(human1.ShowHuman());

            Console.WriteLine("---------------------\n");
            Console.WriteLine("Cейчас выводит конструктор c параметрами.Экземпляр human2 ");
            var human2 = new Human("Patrick", "Rofus",DateTime.Parse("22/06/1995"));
           Console.WriteLine(human2.ShowHuman());
            
            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("Метод проверяющий екземпляр human1 на эквивалентность с human2.");      
            Console.WriteLine( equivalenceChecking(human1,human2));

            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("Тут присвоение значений из human2 в human1");
            human1 = human2;
            Console.WriteLine("\n---------------------\n");

            Console.WriteLine("Cейчас выводит экземпляр human1 ");        
            Console.WriteLine(human1.ShowHuman());

            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("Cейчас выводит экземпляр human2 ");         
            Console.WriteLine(human2.ShowHuman());

            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("Метод проверяющий екземпляр human1 на эквивалентность с human2.");
            Console.WriteLine(equivalenceChecking(human1, human2));

            Console.ReadLine();
        }

        public static string equivalenceChecking(Human hum1, Human hum2)
        {
            if (hum1 == hum2)
            { return "Экземпляры эквивалентны"; }
            return "Экземпляры не эквивалентны";
        }
    }

    class Human
    {


        private string firstName, lastame;
        DateTime birthtday;
        DateTime dateTimeNow = DateTime.Parse(DateTime.Now.ToString());


        public Human()
        {
            firstName = "Lora";
            lastame = "Smith";
            birthtday = DateTime.Parse("27/12/1999");
        }
        

        public Human(string fName, string lName, DateTime dt)
        {
            FirstName = fName;
            LastName = lName;
            Birthtday = dt;
        }


        private DateTime Birthtday
        {
            get { return birthtday; }
            set { birthtday = value; }
        }

        private string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }

        private string LastName
        {
            get { return lastame; }
            set { lastame = value; }
        }
        private int Age
        {
            get
            {
                return (int)(dateTimeNow - birthtday).Days/365 ;
            }
        }

        public string ShowHuman()
        {
            return "\nFirstName " + FirstName+ "\nLastName "+ LastName+ "\nBirthtday "+Birthtday.ToString("dd/MM/yyyy") +"\nAge "+ Age.ToString();
        }
        

    }
}
