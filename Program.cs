using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------Working with String------------------//
            StringCsharp String_OBJ = new StringCsharp();
           // String_OBJ.func();
            //-----------Working with number------------------//
            NumberCsharp Number_OBJ = new NumberCsharp();
            //Number_OBJ.func();

            //---------------Guessing game----------------------//
            GuessingGameCsharp GG_OBJ = new GuessingGameCsharp();
            GG_OBJ.func();
            //-------------------------------------------------//
            Console.ReadLine();
        }
    }
}
