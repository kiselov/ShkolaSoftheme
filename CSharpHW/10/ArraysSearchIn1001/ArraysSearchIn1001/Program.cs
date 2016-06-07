using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSearchIn1001
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Random rnd = new Random();

           
            int[] myArray = new int[1001];
            int maxRand = myArray.Length / 2;
            int randValue = rnd.Next(1, maxRand);


            for (int i = 0,j = 0; j < myArray.Length; i++)
            {
                myArray[j] = i;
                //Console.Write("\n"+myArray[j]);
                j++;
                
                if (i == randValue)                
                    continue;
                if(j< myArray.Length)
                { 
                    
                    myArray[j] = i;
                    //Console.Write(" "+myArray[j]);
                    j++;
                }
            }

            
            int singleElement = 0;
            foreach (int x in myArray)
            { singleElement ^= x; }

          // Console.WriteLine("Cлучайное число "+randValue);
            Console.WriteLine("Одинокий элемент "+ singleElement);




            
            Console.ReadLine();
        }
        
    }
}
