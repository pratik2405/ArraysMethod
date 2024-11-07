using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMethod
{
    internal class Program
    {
        //Declare an array of size 10, use Sort(), Reverse(), Copy(), Clear()
       // Copy → copy from first array from index 3 & total 4 elements in second array

        static void Main(string[] args)
        {
            int []arr1=new int[10] {40,50,10,88,12,9,44,63,65,52};
            int[] arr2 = new int[5];

            Console.WriteLine("Origanl Array");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("Sorted Array");
            Array.Sort(arr1);
            for (int i = 0; i < arr1.Length; i++) 
            { 
            Console.WriteLine(arr1[i]); 
            }

            Console.WriteLine("Reverse Array");
            Array.Reverse(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("Clear() method");
            //this method only replace with 0
            //parameter==> (array name , start index , count of elements) 
            Array.Clear(arr1, 8, 2);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("Copy() Method => copy element in arr2 from arr1");

            Array.Copy(arr1, 3, arr2, 0, 5);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }


        }
    }
}
