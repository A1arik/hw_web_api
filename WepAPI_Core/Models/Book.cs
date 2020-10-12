using System.Collections.Generic;
using Newtonsoft.Json;

namespace WepAPI_Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public ICollection<Author> Authors { get; set; }
        public ICollection<Genre> Genres { get; set; }

        public Book()
        {
            Authors = new List<Author>();
            Genres = new List<Genre>();
        }
    }



}
