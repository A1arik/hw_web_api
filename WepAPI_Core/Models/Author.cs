﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WepAPI_Core.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Img { get; set; }

        [JsonIgnore]
        public virtual ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}