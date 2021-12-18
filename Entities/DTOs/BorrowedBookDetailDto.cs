using Core;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BorrowedBookDetailDto:IDto
    {
        public int BorrowedBookId { get; set; }
        public string BookName { get; set; }
        public DateTime BorrowedTime { get; set; }
        public DateTime DeliveryTime { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
