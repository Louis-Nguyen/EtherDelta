using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtherDeltaAPI.ISerives;
using EtherDeltaAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtherDeltaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServices _accountServices;

        public AccountController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }
        [EnableCors]
        [HttpPost]
        public async Task<IActionResult> createAccount(Account account)
        {
            bool result = _accountServices.createAccount(account);
            if (result)
            {
                return Ok(); 
            }
            else
            {
                return NoContent();
            }
        }
        [EnableCors]
        [HttpGet]
        public async Task<IActionResult> getAllAccount()
        {
            return Ok(await _accountServices.getAllAccount());
        }
    }
}