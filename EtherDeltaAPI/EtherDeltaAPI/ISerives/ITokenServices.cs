using EtherDeltaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtherDeltaAPI.ISerives
{
   public interface ITokenServices
    {
        Task<ActionResult<IEnumerable<Token>>> getAllTokens();
        bool createToken(List<Token> tokens);
        Token getTokenByName(string name);
    }
}
