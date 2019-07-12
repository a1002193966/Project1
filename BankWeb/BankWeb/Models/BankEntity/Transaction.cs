using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankWeb.Models.BankEntity
{
    public class Transaction
    {
        [Key]
        public int TransId { get; set; }

        public string Operation { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }


        [Display(Name = "Account ID")]
        public int AccId { get; set; }

        public virtual Account Acc { get; set; }

    }
}
