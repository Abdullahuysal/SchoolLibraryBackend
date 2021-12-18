using Business.Abstract;
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

        public List<BorrowedBook> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<BorrowedBookDetailDto> GetBorrowedBookDetail()
        {
            return _borrowedBookDal.GetBorrowedBookDetail();
        }

        public BorrowedBook GetById(int borrowedBookId)
        {
            throw new NotImplementedException();
        }
    }
}
