using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public  int Id { get; set; }
        public Book(string title, string author,string genre, int id)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Id = id;
        }
        public override string ToString()
        {
            return $"{Title} by {Author},Genre:{Genre}, Id: {Id}";
        }
    }
}
