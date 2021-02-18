using System;

namespace C_sharp
{
    public delegate void MyDelegate(int num);
    public delegate Inheritance covardel(BookAuthor bookAuthor);
    class Program
    {
        private static Func<BookAuthor, Inheritance> covardel;

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

           /* Console.WriteLine(inheritance.authorName);
            Console.WriteLine(bookAuthor.authorName);
            inheritance.showclass();*/

            //---------------Collections-------------------//
            Collections collections = new Collections();
            //collections.func();

            //---------------Delegates---------------------//
            //Delegates delegates = new Delegates();
            MyDelegate nm = Delegates.sqr;
            //nm(10);

            //--------------Event---------------------------//
            EventsManage eventsManage = new EventsManage();
            /*eventsManage.TaskCompleted += eventsManage.completed;
            eventsManage.ProcessCompleted += eventsManage.Pcompleted;
            eventsManage.TaskStart();*/

            //--------------Covariance-------------------------//
            covardel del= ConvarianceCsharp.M1;
            Inheritance in1= del(new BookAuthor());

            //-------------------------------------------------//
            Console.ReadLine();
        }
    }
}
