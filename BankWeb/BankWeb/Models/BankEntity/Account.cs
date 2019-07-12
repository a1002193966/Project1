using BankWeb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankWeb.Models.BankEntity
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Account #")]
        public int AccountNumber { get; set; }

        [Display(Name = "Routing #")]
        public int? RoutingNumber { get; set; }

        public double Balance { get; set; }

        [Display(Name = "Interest Rate")]
        public double? Interest { get; set; }

        public bool IsActive { get; set; }

        [Display(Name = "Account Type")]
        public string AccountType { get; set; }

        [Display(Name = "Date Opened")]
        public DateTime DateOpened { get; set; }

        [Display(Name = "Date Closed")]
        public DateTime? DateClosed { get; set; }

        public string CustomerId { get; set; }
        public virtual ApplicationUser AppUser { get; set; }
        
        public List<Transaction> Trans { get; set; }
    }
}
