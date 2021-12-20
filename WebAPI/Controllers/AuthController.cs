using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
    public class AuthController : ControllerBase
    {
        IStudentService _studentService;
        IAuthService _authService;
        public AuthController(IStudentService studentService, IAuthService authService)
        {
            _studentService = studentService;
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult login(StudentForLoginDto studentForLoginDto)
        {
            var userToLogin = _studentService.login(studentForLoginDto);
            if (userToLogin.Success)
            {
                return Ok(userToLogin.Data);
            }
            return BadRequest(userToLogin);
        }
        [HttpPost("register")]
        public ActionResult register(StudentForRegisterDto studentForRegisterDto)
        {
            var userToRegister = _authService.Register(studentForRegisterDto);
            if (userToRegister.Success)
            {
                return Ok(userToRegister.Data);

            }
    
            return BadRequest(userToRegister);

        }

    }
}
