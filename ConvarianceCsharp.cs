using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class ConvarianceCsharp
    {
        public static Inheritance M1(BookAuthor bookAuthor)
        {
            Console.WriteLine("Method 1");
            return new Inheritance();
        }

        public static BookAuthor M2(BookAuthor bookAuthor)
        {
            Console.WriteLine("Method 2");
            return new Inheritance();
        }
    }
}
