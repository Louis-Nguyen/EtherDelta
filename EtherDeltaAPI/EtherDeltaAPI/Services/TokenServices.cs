using EtherDeltaAPI.ISerives;
using EtherDeltaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtherDeltaAPI.Services
{
    public class TokenServices : ITokenServices
    {
        private readonly EtherdeltaDBContext _etherdeltaDBContext;

        public TokenServices(EtherdeltaDBContext etherdeltaDBContext)
        {
            _etherdeltaDBContext = etherdeltaDBContext;
        }

        public bool createToken(List<Token> tokens)
        {
            try
            {
                _etherdeltaDBContext.Token.AddRange(tokens);
                _etherdeltaDBContext.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
           
        }

        public async Task<ActionResult<IEnumerable<Token>>> getAllTokens()
        {
            var entity = await _etherdeltaDBContext.Token.ToListAsync();
            return entity;
        }

        public Token getTokenByName(string name)
        {
            var query = from item in _etherdeltaDBContext.Token
                        where item.Name == name
                        select item;

            var token =  query.FirstOrDefault<Token>();
            return token;
        }
    }
}
