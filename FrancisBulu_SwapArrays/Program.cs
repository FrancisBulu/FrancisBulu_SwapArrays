using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisBulu_SwapArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 6, 5, 4, 3, 2, 1 };
           
            for (int i = 0; i < arr1.Length; i++)
            {
                int j = arr2.Length - arr2[i];
                
                Console.Write($"The new arr2 is {arr2[i]} ");


                Console.WriteLine($"The new arr1 is {j+1}");

            }
        }
    }
}
