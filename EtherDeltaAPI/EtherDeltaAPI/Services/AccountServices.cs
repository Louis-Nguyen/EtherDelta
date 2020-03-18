using EtherDeltaAPI.ISerives;
using EtherDeltaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtherDeltaAPI.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly EtherdeltaDBContext _etherdeltaDBContext;

        public AccountServices(EtherdeltaDBContext etherdeltaDBContext)
        {
            _etherdeltaDBContext = etherdeltaDBContext;
        }

        public bool createAccount(Account account)
        {
            try
            {
                _etherdeltaDBContext.Account.Add(account);
                _etherdeltaDBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ActionResult<IEnumerable<Account>>> getAllAccount()
        {
            var entity = await _etherdeltaDBContext.Account.ToListAsync();
            return entity;
        }
    }
}
