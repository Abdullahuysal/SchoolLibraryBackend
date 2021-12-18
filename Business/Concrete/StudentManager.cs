using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
            if(student.StudentEmail==null || student.StudentName==null || student.StudentLastName==null || student.StudentNumber==0 || student.StudentPassword == null)
            {
                return new ErrorResult(Messages.StudentInformationMissing);
            }
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IDataResult<List<Student>> GetAll()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<Student>>(Messages.StudentTableError);
            }
            
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
    }
}
