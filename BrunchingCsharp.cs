using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class BrunchingCsharp
    {
        public void switchcaseDay(string day)
        {
            
        }
        public void func()
        {
            int num1 = 3, num2 = 6;
            if (num1 < num2)
            {
                Console.WriteLine(num1+" is smaller than "+num2);
            } else if (num2 < num1)
            {
                Console.WriteLine(num2 + " is smaller than " + num1);
            } else
            {
                Console.WriteLine(num2 + " is equal to " + num1);
            }

            int day = 6;
            switch (day)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("not found");
                    break;
            }
        }
    }
}
