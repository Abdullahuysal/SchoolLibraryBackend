using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result = _bookService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        

        [HttpPost("add")]
        public IActionResult Add(Book book)
        {
            var result = _bookService.Add(book);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbybookname")]
        public IActionResult GetByBookname(string bookname)
        {
            var result = _bookService.GetAllByName(bookname);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
           
        }
        
    }
}
