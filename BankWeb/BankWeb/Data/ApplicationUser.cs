using BankWeb.Models.BankEntity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Account> MyAccount { get; set; }
    }
}
