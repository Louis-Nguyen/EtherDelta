using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EtherDeltaAPI.Models
{
    public class Account
    {       [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [StringLength(100)]
            public string Address { get; set; }
            public string Info { get; set; }
            public string Keyprivate { get; set; }
    }
}
