using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Box<T>
    {
        public T Value;

        public void getValue()
        {
            Console.WriteLine(Value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

            Console.WriteLine(marks[3]);

            int[,] matrix =
            {
                {23,45,65,34,44 },
                {12,23,42,54,76 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i,j]);
                }
            }


            //Array methods 
            Console.WriteLine("Array Methods: ");
            int[] arr = { 3, 2, 6, 9, 7, 5 };
            Console.Write("Main Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

            Array.Reverse(arr);
            Console.Write("Reverse Array: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " +arr[i]);
            }
            Console.WriteLine();
            Array.Sort(arr);
            Console.Write("Sort Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Length of Array: " + arr.Length);
            //Find the index of specific value:
            Console.WriteLine("Index of 9: " +Array.IndexOf(arr, 9));
            Console.WriteLine("Index of 54: " +Array.IndexOf(arr, 54));

            Console.ReadLine(); 
        }
    }
}
