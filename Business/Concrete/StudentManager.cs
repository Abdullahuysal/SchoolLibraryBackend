using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IResult Add(Student student)
        {
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }
        public IResult Update(Student student)
        {
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Update(student);
            return new SuccessResult(Messages.StudentUpdated);
        }

        public IDataResult<List<Student>> GetAll()
        {
            
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll());
        }

        public IDataResult<Student> GetByemail(string studentemail)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(s => s.StudentEmail == studentemail));
        }

        public IDataResult<Student> GetById(int studentId)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(s => s.StudentId == studentId));
        }

        public IDataResult<Student> login(StudentForLoginDto studentForLoginDto)
        {

            return new SuccessDataResult<Student>(_studentDal.Get(s => s.StudentEmail == studentForLoginDto.StudentEmail &&
            s.StudentPassword == studentForLoginDto.StudentPassword));
        }

    }
}
