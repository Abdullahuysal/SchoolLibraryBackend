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
       
    }
}
