using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class Book
    {
        //get set control access
            public string Title { get; set; }
            public string Author { get; set; }
            public double Price { get; set; }

        public Book()
        {

        }

        //constructor method matched the classname
        //constructor
        //no return types
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string BookInfo()
        {
            return $"The book {Title} was written by {Author} and " +
                $"it costs {Price}";
        }
    }
}
