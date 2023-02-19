using BCrypt.Net;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly FamilyEventContext _context;
        private readonly IConfiguration _config;
        private IAccount _accountService;
        public AccountController(IAccount accountService, FamilyEventContext context, IConfiguration config)
        {
            this._accountService = accountService;
            _context = context;
            _config = config;
        }
       

       // [HttpPost]
        //public IActionResult Login([FromBody] Account account)
       // {
           /* IActionResult response = Unauthorized();
            var accountFromDb = AuthenticateUser(account);

            if (accountFromDb != null)
            {
                var tokenString = AuthenticateUser(account);
                response = Ok(new { token = tokenString });
            }

            return response;*/
      //  }

        /*private Account AuthenticateUser(Account login)
        {
            //Account account1 = _context.Account.FirstOrDefault(u => u.UserName == login.UserName && u.Password == login.Password);
            Account account2 = _context.Account.FirstOrDefault(u => u.Email == login.Email && u.Password == login.Password);
            Account account3 = _context.Account.FirstOrDefault(u => u.Phone == login.Phone && u.Password == login.Password);
            if (account1 != null)
            {
                return account1;
            }
            else if (account2 != null)
            {
                return account2;
            }
            else
            {
                return account3;
            }
            return null;
        }*/

    }
}
