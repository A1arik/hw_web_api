using System.Collections.Generic;
using Newtonsoft.Json;

namespace WepAPI_Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

}
