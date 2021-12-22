using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BorrowedBookManager : IBorrowedBookService
    {
        IBorrowedBookDal _borrowedBookDal;

        public BorrowedBookManager(IBorrowedBookDal borrowedBookDal)
        {
            _borrowedBookDal = borrowedBookDal;
        }

        public IDataResult<List<BorrowedBook>> GetById(int studentId)
        {
            return new SuccessDataResult<List<BorrowedBook>>(_borrowedBookDal.GetAll(b => b.StudentId == studentId));
        }
    }
}
