using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBookDal
    {
        List<Book> GetAll();

        void Add(Book book);

        void Update(Book book);

        void Delete(Book book);

        List<Book> GetAllByCategory(string categoryName);

    }
}
