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
    public class TokenController : ControllerBase
    {
        private readonly ITokenServices _tokenServices;

        public TokenController(ITokenServices tokenServices)
        {
            _tokenServices = tokenServices;
        }
        [EnableCors]
        [HttpGet]
        public async Task<IActionResult> getAllToken()
        {
            var infoToken = new { 
                Tokens = await _tokenServices.getAllTokens(),
                DefaultToken = _tokenServices.getTokenByName("DAI")
        };
            return  Ok(infoToken);
        }

        [EnableCors]
        [HttpPost]
        public async Task<IActionResult> createToken(List<Token> tokens)
        {
            bool result = _tokenServices.createToken(tokens);
            if (result)
            {
                return Ok();
            }
            else return NoContent();
        }
    }
}