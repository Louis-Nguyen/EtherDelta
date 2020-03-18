using EtherDeltaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtherDeltaAPI.ISerives
{
   public interface IAccountServices
    {
        bool createAccount(Account account);
        Task<ActionResult<IEnumerable<Account>>> getAllAccount();
    }
}
