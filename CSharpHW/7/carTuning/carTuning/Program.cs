using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carTuning
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.ShowCar();

            Console.ReadKey();

        }
    }
    class Car
    {
        private string model = "Ford";
        private int year = 1998;
        private string color = "Blue";

        public string Model
        {
            get { return model; }
        }

        public int Year
        {
            get { return year; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowCar()

       {
            Console.Write("Car: " + "\nModel: {0} \nYear: {1} \nColor: ",Model,Year);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Color);
            Console.ResetColor();
            Console.WriteLine("\nЦвет после тюнинга");
            Console.Write("\nColor: ");
            TuningAtelier.TuneCar(Color);

           

        }

        
    }
  public static class TuningAtelier
    {
        public static void TuneCar( string car)
        {
            car = "Red";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(car);
            Console.ResetColor();
           
        }
    }
}
