using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class NumberCsharp
    {
        public void func()
        {
            //-----------Working with number------------------//
            int num = 1000;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num / 300);
            Console.WriteLine(num / 300.0);
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);
            Console.WriteLine(Math.Sqrt(num));
            Console.WriteLine(Math.Max(4, 59));
            Console.WriteLine(Math.Min(4, 59));
            Console.WriteLine(Math.Round(4.6));
            Console.WriteLine(Math.Ceiling(4.7));
            Console.WriteLine(Math.Floor(4.7));

            //double dnum; dnum = Convert.ToDouble(Console.ReadLine());
        }
    }
}
