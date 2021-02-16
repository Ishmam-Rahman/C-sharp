using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class StringCsharp
    {
        public void func()
        {
            //---------Working with string------------------//
            String st = "ishmam rahman Omi";
            Console.WriteLine("Enter a string: ");
            st = Console.ReadLine();
            Console.WriteLine("String is " + st);

            //Get the string length
            Console.WriteLine("Lenght of st is " + st.Length);

            //get perticular index charecter
            Console.WriteLine(st[3]);

            //get starting index of a substring
            Console.WriteLine(st.IndexOf("rahman"));

            //change charecter case
            Console.WriteLine(st.ToUpper());
            Console.WriteLine(st.ToLower());

            // return as per pattern exist in string
            Console.WriteLine(st.Contains("Ishmam Omi"));

            //get the substrng
            Console.WriteLine(st.Substring(14, 3));
        }

        public static implicit operator StringCsharp(NumberCsharp v)
        {
            throw new NotImplementedException();
        }
    }
}
