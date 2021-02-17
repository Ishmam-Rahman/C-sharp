using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp
{
    class IndexerCsharp
    {
        List<BookAuthor> authorlist = new List<BookAuthor>()
        {
            new BookAuthor("ishmam",23),
            new BookAuthor("Omi",22) ,
            new BookAuthor("Omio",21),
        };

        public string this[int authorage]
        {
            get { return authorlist.FirstOrDefault(c => c.authorAge == authorage).authorName; }

            set { authorlist.FirstOrDefault(c => c.authorAge == authorage).authorName = value; }
        }
    }
}
