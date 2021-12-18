using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager(new EfStudentDal());

            var result = studentManager.GetAll();
            if (result.Success == true)
            {
                foreach (var student in result.Data)
                {
                    Console.WriteLine(student.StudentEmail + "---" + student.StudentName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

   
    }
}
