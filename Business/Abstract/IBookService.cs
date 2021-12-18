using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
     
        IDataResult<List<Book>> GetAllByName(string BookName);

        IResult Add(Book book);
    }
}
