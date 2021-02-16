using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp
{
    class ArrayCsharp
    {
        public void func()
        {
            //Array Declaration
            int[] numarray = new int[5];
            string[] chararray; chararray = new string[5];

            //Array Declaration & Initialization
            int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };

            //Array Declaration using var
            var evenNum = new int[] { 2, 4, 6, 8, 10 };

            Console.WriteLine(evenNum[2] + evenNums[1]);

            foreach (var item in evenNums) Console.WriteLine(item);

            //-----------LINQ Method----------------//
            evenNums.Max(); // returns 16
            evenNums.Min(); // returns 6
            evenNums.Sum(); // returns 55
            evenNums.Average(); // returns 55

            //-----------Array Method----------------//
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            Array.Sort(nums); // sorts array 
            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
            Array.BinarySearch(nums, 5);// binary search 


            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };
            Console.WriteLine(arr2d[0, 0]);
        }
    }
}
