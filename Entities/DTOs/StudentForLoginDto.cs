using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class StudentForLoginDto:IDto
    {
        public string StudentEmail { get; set; }
        public string StudentPassword { get; set; }
    }
}
