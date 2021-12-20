using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IStudentService _studentService;
        public AuthManager(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IDataResult<Student> Register(StudentForRegisterDto userForRegisterDto)
        {
            var student = new Student
            {
                StudentNumber = userForRegisterDto.StudentNumber,
                StudentName = userForRegisterDto.StudentName,
                StudentLastName=userForRegisterDto.StudentLastName,
                StudentEmail = userForRegisterDto.StudentEmail,
                StudentPassword=userForRegisterDto.StudentPassword
                
            };
            _studentService.Add(student);
            return new SuccessDataResult<Student>(student, Messages.StudentAdded);

        }
    }
}
