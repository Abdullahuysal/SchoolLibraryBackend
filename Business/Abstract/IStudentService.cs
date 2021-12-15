using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int studentId);
    }
}
