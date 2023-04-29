using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._29._2023.Models
{
    internal class Book
    {
        public static int Count { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public string Code { get; private set; }
         

        public Book(string name, string authorName, int pageCount, double price)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Price = price;
            Count++;
            Code = MakeACode(name);


        }
        private string MakeACode(string name)
        {
            string[] word = name.Split(" ");
            Code = "";
            for (int i = 0; i < word.Length; i++)
            {
                Code += word[i][0];
            }

            return Code +"-"+ Count;
        }
        public override string ToString()
        {
            return $"{Name},{AuthorName},{PageCount},{Price},{Code}";
        }



    }

}
