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
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IResult Add(Book book)
        {
            if(book.BookName==null || book.BookAuthor==null|| book.BookCategory==null)
            {
                return  new ErrorResult(Messages.BookAddError);
            }
            _bookDal.Add(book);
            return new SuccessResult(Messages.BookAddSuccess);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

      

        public IDataResult<List<Book>> GetAllByName(string BookName)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.BookName == BookName));
        }
    }
}
