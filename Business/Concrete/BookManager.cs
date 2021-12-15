using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetAllByCategory(string BookCategory)
        {
            return _bookDal.GetAll(p => p.BookCategory == BookCategory);
        }

        public List<Book> GetAllByName(string BookName)
        {
            return _bookDal.GetAll(p => p.BookName==BookName);
        }
    }
}
