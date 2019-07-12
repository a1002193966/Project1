using BankWeb.Models.BankEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankWeb.List
{
    public class AccountList
    {
        public Account Act { get; set; }
        public List<Checking> CList { get; set; }
        public List<Business> BList { get; set; }
        public List<TermDeposit> TList { get; set; }
    }
}
