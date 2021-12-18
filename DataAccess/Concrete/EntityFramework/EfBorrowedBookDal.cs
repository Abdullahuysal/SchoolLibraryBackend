using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfBorrowedBookDal : EfEntityRepositoryBase<BorrowedBook, SchoolLibraryContext>, IBorrowedBookDal
    {
        public List<BorrowedBookDetailDto> GetBorrowedBookDetail()
        {
            using (SchoolLibraryContext context =new SchoolLibraryContext())
            {
                var result = from b in context.BorrowedBook
                             join s in context.Student
                             on b.StudentId equals s.StudentId
                             select new BorrowedBookDetailDto {
                                 BorrowedBookId = b.BorrowedBookId, BookName = b.BookName,
                                 BorrowedTime = b.BorrowedTime, DeliveryTime = b.DeliveryTime,
                                 StudentId=s.StudentId
                                 
                             };


                return result.ToList();
            }

        }
    }
}
