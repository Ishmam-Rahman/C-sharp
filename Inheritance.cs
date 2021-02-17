using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class Inheritance : BookAuthor
    {
        public string BookName;
        public int BookPage;


        public Inheritance(string BN, int BP):base("ishmam",222)
        {
            BookName = BN;
            BookPage = BP;
        }

        public override void showclass()
        {
            base.showclass();
            Console.WriteLine("Child class");
        }

    }
}
