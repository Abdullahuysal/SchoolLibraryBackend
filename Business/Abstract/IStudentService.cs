using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult <Student> GetById(int studentId);
        IDataResult<Student> GetByemail(string studentemail);
        IResult Add(Student student);
    }
}
