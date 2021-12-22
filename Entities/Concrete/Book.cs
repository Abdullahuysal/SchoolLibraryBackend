using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int BookId { get; set; }
        public string BookCategory { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int BookPageCount { get; set; }
        public bool Bookavailability { get; set; }


    }
}
