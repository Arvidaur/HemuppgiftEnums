using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftEnums
{
    class Book
    {
        //Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        //Constructor
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }


        //Printing book info
        public string GetBookInfo()
        {
            return $"Title: {Title}, Author: {Author}, Pages: {Pages}";
        }
    }
}
