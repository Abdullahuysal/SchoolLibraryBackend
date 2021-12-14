﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BorrowedBook:IEntity
    {
        public int BorrowedBookId { get; set; }
        public string BookName { get; set; }
        public DateTime BorrowedTime { get; set; }
        public DateTime DeliveryTime { get; set; }
        public Student Student { get; set; }
    }
}