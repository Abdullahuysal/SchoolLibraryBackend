using Business.Abstract;
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

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public Student GetById(int studentId)
        {
            return _studentDal.Get(s => s.StudentId == studentId);
        }
    }
}
