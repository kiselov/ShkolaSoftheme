using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            var creatCar = new CarConstructor();
            string choice;
            int engineIn;
            int colorIn;
            int transmIn;
            Console.WriteLine("Добро пожаловать в конструктор машин.\n");

        labelStart:
            try
            {
               
                
                Console.WriteLine("\nВыбирите двигатель\n" +
                    "Бензин - 1 \nДизель - 2 \nГаз - 3 \nГибрид - 4");
                engineIn = int.Parse(Console.ReadLine());
                if (engineIn < 1 || engineIn > 4) {
                    throw new Exception();
                        }
                Console.WriteLine("\nВыбирите Цвет\n" +
                    "синий - 1 \nкрасный - 2 \nжелтый - 3 \nзеленый - 4"); ;
                colorIn = int.Parse(Console.ReadLine());
                if (colorIn < 1 || colorIn > 4)
                {
                    throw new Exception();
                }
                Console.WriteLine("\nВыбирите трансмиссию\n" +
                    "механика - 1 \nавтоматика - 2 \nиптроник - 3"); 
                transmIn = int.Parse(Console.ReadLine());

                if (transmIn < 1 || transmIn >3)
                {
                    throw new Exception();
                }

                creatCar.Constructor(engineIn, transmIn, colorIn);
                Console.WriteLine("\n------------------\n");
                Console.WriteLine("\nВот что получилось.");
                Console.WriteLine(creatCar.Car);


                Console.WriteLine("\nВы можете заменить двигатель. \nЕсли хотите введите y.");
                choice = Console.ReadLine();
                if (choice == "y")
                {
                    Console.WriteLine("\nВыбирите двигатель\n" +
                    "Бензин - 1 \nДизель - 2 \nГаз - 3 \nГибрид - 4");
                    engineIn = int.Parse(Console.ReadLine());
                    if (engineIn < 1 || engineIn > 4)
                    {
                        throw new Exception();
                    }
                    creatCar.Reconstruct(engineIn);
                    Console.WriteLine("\n------------------\n");
                    Console.WriteLine("\nВот что получилось.");
                    Console.WriteLine(creatCar.Car);
                }

            }
            catch
            {
                Console.WriteLine("Вы где-то допустили ошибку");
                Console.WriteLine("Хотите начать заново? y/n\n");
                choice = Console.ReadLine();
                if (choice == "y")
                {
                    goto labelStart;
                }
            }
            Console.Read();
          }  

    }

    class Engine
    {
        private string engineType;
        public string SelectionEngine(int type)
        {

            switch (type)
            {
                case 1:
                    BenzineType();
                    break;
                case 2:
                    DieselType();
                    break;
                case 3:
                    GasType();
                    break;
                case 4:
                    HybridType();
                    break;
            }
            return engineType;
        }
        
        private void BenzineType()
        {
            engineType = "бензин";
        }

        private void DieselType()
        {
            engineType = "дизель";
        }

        private void GasType()
        {
            engineType = "газ";
        }

        private void HybridType()
        {
            engineType = "гибрид";
        }
    }


    class Color
    {
        private string colorCar;
        public string ColorCar { get { return colorCar; } }
        public string SelectionColor(int colorIn)
        {
            switch (colorIn)
            {
                case 1:
                    BlueColor();
                    break;
                case 2:
                    YellowColor();
                    break;
                case 3:
                    RedColor();
                    break;
                case 4:
                    GreenColor();
                    break;
            }
            return colorCar;
        }

        private void BlueColor()
        {
            colorCar = "синий";                      
        }

        private void RedColor()
        {
            colorCar = "красный";         
        }

        private void YellowColor()
        {
            colorCar = "желтый";                   
        }

        private void GreenColor()
        {
            colorCar = "зеленый";          
        }
    }


    class Transmission
    {
        private string transmissionType;
        public string TransmissionType { get { return transmissionType; } }
        public string SelectionTransmission(int transmission)
        {
            switch (transmission)
            {
                case 1:
                    MechanicsType();
                    break;
                case 2:
                    AutomaticType();
                    break;
                case 3:
                    TiptronicType();
                    break;
            }
            return transmissionType;
        }
        private void MechanicsType()
        {
            transmissionType = "механика";
        }

        private void AutomaticType()
        {
            transmissionType = "автоматика";
        }

        private void TiptronicType()
        {
            transmissionType = "типтроник";
        }
    }
    class CarConstructor
    {
        Engine engine = new Engine();
        Transmission transm = new Transmission();
        Color color = new Color();
      private  string car;
        public string Car
        {
            get { return car; }
        }
        public void Constructor(int e, int t, int c )
        {
            
            transm.SelectionTransmission(t);
            color.SelectionColor(c);
            car = "\nДанные машины\nДвигатель " + engine.SelectionEngine(e) +
                "\nТрансмиссия " + transm.SelectionTransmission(t)+"\nЦвет " + color.SelectionColor(c);
        }
        public void Reconstruct(int e)       
        {
            car = "\nДанные машины\nДвигатель " + engine.SelectionEngine(e) +
                "\nТрансмиссия " + transm.TransmissionType + "\nЦвет " + color.ColorCar;
        }
    }

}