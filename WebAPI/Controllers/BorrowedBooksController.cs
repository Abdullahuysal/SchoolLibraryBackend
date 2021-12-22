using Business.Abstract;
using Entities.Concrete;
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
    public class BorrowedBooksController : ControllerBase
    {
        IBorrowedBookService _borrowedBookService;
        public BorrowedBooksController(IBorrowedBookService borrowedBookService)
        {
            _borrowedBookService = borrowedBookService;
        }
        [HttpGet("get")]
        public IActionResult Get(int studentId)
        {
            var result = _borrowedBookService.GetById(studentId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
