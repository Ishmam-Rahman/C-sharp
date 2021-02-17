using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class BookAuthor
    {
        protected string AuthorName;
        protected int AuthorAge;

        public virtual void showclass()
        {
            Console.WriteLine("Super class");
        }


        public BookAuthor(string AN, int AA)
        {
            AuthorAge = AA;
            AuthorName = AN;
        }

        public string authorName
        {
            get { return AuthorName; }
            set { AuthorName = value; }
        }

        public int authorAge
        {
            get { return AuthorAge; }
            set { AuthorAge = value; }
        }
    }
}
