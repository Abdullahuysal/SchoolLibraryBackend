using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBookDal : IBookDal
    {
        List<Book> _books;
        public InMemoryBookDal()
        {
            _books = new List<Book> {
            new Book{BookId=1,BookName="deneme1",BookAuthor="Yazar1",BookCategory="roman",BookPageCount=500,BookStockInLibrary=2},
            new Book{BookId=2,BookName="deneme2",BookAuthor="Yazar2",BookCategory="roman2",BookPageCount=502,BookStockInLibrary=4},
            new Book{BookId=6,BookName="deneme6",BookAuthor="Yazar6",BookCategory="roman6",BookPageCount=506,BookStockInLibrary=6}
            };
        }
        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Delete(Book book)
        {
            //SingleOrDefault is a Linq Function .
            Book bookToDelete = _books.SingleOrDefault(p=>p.BookId==book.BookId);
            _books.Remove(bookToDelete);
        }

        public List<Book> GetAll()
        {
            return _books;
        }

        public List<Book> GetAllByCategory(string categoryName)
        {
           return  _books.Where(p => p.BookCategory == categoryName).ToList();
        }

        public void Update(Book book)
        {
            Book bookToUpdate = _books.SingleOrDefault(p => p.BookId == book.BookId);
            bookToUpdate.BookName = book.BookName;
            bookToUpdate.BookCategory = book.BookCategory;
            bookToUpdate.BookAuthor = book.BookAuthor;
            bookToUpdate.BookPageCount = book.BookPageCount;
            bookToUpdate.BookStockInLibrary = book.BookStockInLibrary;
            
        }
    }
}
