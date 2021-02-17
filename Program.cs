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
            //GG_OBJ.func();

            //--------------Properties------------------------//
            PropertiesCsharp propertiesCsharp = new PropertiesCsharp("Ishmam");
            /*Console.WriteLine(propertiesCsharp.Name);
            propertiesCsharp.Name = "Riya";
            Console.WriteLine(propertiesCsharp.Name);*/

            //--------------Loop------------------------//
            LoopCsharp loopCsharp = new LoopCsharp();
            //loopCsharp.func();

            //------------static attribute------------------//
            StaticAttribute staticAttribute = new StaticAttribute();
            /*Console.WriteLine(StaticAttribute.objectcount);
            StaticAttribute staticAttribute1 = new StaticAttribute();
            Console.WriteLine(StaticAttribute.objectcount);*/

            //------------static method------------------//
            //NeedyTools.func("Omi");

            //---------------Inheritance-------------------//
            Inheritance inheritance = new Inheritance("boook",23);
            BookAuthor bookAuthor = new BookAuthor("Riya",22);

            Console.WriteLine(inheritance.authorName);
            Console.WriteLine(bookAuthor.authorName);
            inheritance.showclass();
            //-------------------------------------------------//
            Console.ReadLine();
        }
    }
}
