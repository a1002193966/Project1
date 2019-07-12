using System;
using System.Collections.Generic;
using System.Text;
using BankWeb.Models.BankEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Checking> Checking { get; set; }
        public DbSet<Business> Business { get; set; }
        public DbSet<TermDeposit> TermDeposit { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<Transaction> Transaction { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Account>()
                .HasOne(u => u.AppUser)
                .WithMany(a => a.MyAccount)
                .HasForeignKey(k => k.CustomerId)
                .HasConstraintName("CustomerId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.Entity<Transaction>()
                .HasOne(a => a.Acc)
                .WithMany(t => t.Trans)
                .HasForeignKey(k => k.AccId)
                .HasConstraintName("AccId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
