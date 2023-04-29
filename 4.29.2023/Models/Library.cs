using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._29._2023.Models
{


    internal class Library
    {


        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void ShowAllBook()
        {

            books.ForEach(x => Console.WriteLine(x));
        }

        public void GetBook(string book)
        {
            Console.WriteLine(books.Find(x => x.Name.ToLower() == book.ToLower()));
        }
        public void FindAllBook(string book)
        {
            Console.WriteLine(books.FindAll(x => x.Name.ToLower() == book.ToLower() || x.Name.ToLower() == book.ToLower()));
        }
        public void RemoveAllBook(string book)
        {
            var count = (books.RemoveAll(x => x.Name.ToLower() == book.ToLower() || x.AuthorName.ToLower() == book.ToLower()));
            Book.Count -= count;
            Console.WriteLine(count);
        }
    }


}
