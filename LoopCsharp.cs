using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class LoopCsharp
    {
        string[] nameset = { "ishmam", "zakir", "akash" };
        public void func()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(nameset[i]);
            }

            int ii = 3;
            while (ii-- >0)
            {
                Console.WriteLine("Enter a string: ");
                nameset[ii] = Console.ReadLine();
            }
            foreach (string item in nameset) Console.WriteLine(item);
        }

    }
}
