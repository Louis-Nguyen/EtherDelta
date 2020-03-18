using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtherDeltaAPI.Models
{
    public class EtherdeltaDBContext :DbContext
    {
        public EtherdeltaDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Token> Token { get; set; }
    }
}
