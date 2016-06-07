﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] nums = new int[7];
            Console.WriteLine("Пузырьковая сортировка");
            Console.WriteLine("Введите семь чисел");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nДо сортировки \n");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.ReadLine();

            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nПосле сортировки\n");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write (nums[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
