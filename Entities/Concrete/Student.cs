using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPassword { get; set; }
    }
}
