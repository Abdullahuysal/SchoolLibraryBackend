using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
        IResult Update(Student student);
        IDataResult<Student> login(StudentForLoginDto studentForLoginDto);

    }
}
