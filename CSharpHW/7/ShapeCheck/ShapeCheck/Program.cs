using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конструктор на 2 точки.\nКординаты: 2, 2, 0, 0");
            var shD = new ShapeDescriptor(2, 2, 0, 0);
            shD.ShapeType();
            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("Конструктор на 3 точки.\nКординаты: 2, 3, 4, 4, 4, 6");
            var shD1 = new ShapeDescriptor(2, 3, 4, 4, 4, 6);
            shD1.ShapeType();
            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("Конструктор на 4 точки.\nКординаты: 2, 2, 3, 1,5,5,6,8");
            var shD2 = new ShapeDescriptor(2, 2, 3, 1,5,5,6,8);
            shD2.ShapeType();
       
            Console.Read();

        }
    }

    class ShapeDescriptor
   {
        private int points=0;
        Point point1 = new Point();
        Point point2 = new Point();
        Point point3 = new Point();
        Point point4 = new Point();
        
        public ShapeDescriptor(int x1, int y1, int x2, int y2)
        {
            point1.X = x1;
            point1.X = y1;
            point2.X = x2;
            point2.X = y2;         
        }

        public ShapeDescriptor(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            point1.X = x1;
            point1.X = y1;
            point2.X = x2;
            point2.X = y2;
            point3.X = x3;           
            point3.X = y3;       
        }

        public ShapeDescriptor(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            point1.X = x1;
            point1.X = y1;
            point2.X = x2;
            point2.X = y2;
            point3.X = x3;
            point3.X = y3;
            point4.X = x4;
            point4.X = y4;
        }
      
        
      public void ShapeType()
        {
            if (point1.checkPoint())
            {
                points += 1;
            }


            if (point2.checkPoint())
            {
                points += 1;
            }

            if (point3.checkPoint())
            {
                points += 1;
            }

            if (point4.checkPoint())
            {
                points += 1;
            }


            switch (points)
            {               
                case 2:
                    Console.WriteLine("Данная фигура отрезок.");
                    break;
                case 3:
                    Console.WriteLine("Данная фигура треугольник.");
                    break;
                case 4:
                    Console.WriteLine("Данная фигура четырехугольник.");
                    break;                
            }
        }

    }
    class Point
    {
        private int? x=null, y=null; 
        public int? X
        {
            get { return x; }
            set { x = value; }
        }

        public int? Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool checkPoint()
        {
            if (X != null)
            { return true; }
            return false;
        }

    }
}
