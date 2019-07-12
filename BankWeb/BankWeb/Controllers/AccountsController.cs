using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankWeb.Data;
using Microsoft.AspNetCore.Authorization;
using BankWeb.List;
using BankWeb.Models.BankEntity;

namespace BankWeb.Controllers
{

    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context) { _context = context; }

        public IActionResult Index() { return View(); }

        #region Getters
        // GET: CHECKING
        [Authorize]
        public async Task<IActionResult> GetChecking()
        {
            string CustId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.Checking.Include(c => c.AppUser)
                .Where(c => c.CustomerId == CustId && c.IsActive == true && c.AccountType == "Checking");

            return View(await applicationDbContext.ToListAsync());
        }

         
        // GET: BUSINESS
        [Authorize]
        public async Task<IActionResult> GetBusiness()
        {
            string CustId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.Business.Include(c => c.AppUser)
                .Where(c => c.CustomerId == CustId && c.IsActive == true && c.AccountType == "Business");

            return View(await applicationDbContext.ToListAsync());
        }


        // GET: TD
        [Authorize]
        public async Task<IActionResult> GetTermDeposit()
        {
            string CustId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.TermDeposit.Include(c => c.AppUser)
                .Where(c => c.CustomerId == CustId && c.IsActive == true && c.AccountType == "TermDeposit");

            return View(await applicationDbContext.ToListAsync());
        }


        // GET: LOAN
        [Authorize]
        public async Task<IActionResult> GetLoan()
        {
            string CustId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.Loan.Include(c => c.AppUser)
                .Where(c => c.CustomerId == CustId && c.IsActive == true && c.AccountType == "Loan");

            return View(await applicationDbContext.ToListAsync());
        }

        //GET: Transaction
        [Authorize]
        public async Task<IActionResult> GetTrans(int? id, DateTime? from, DateTime? to, string indicator)
        {
            var applicationDbContext = _context.Transaction.Include(t => t.Acc).Where(m => m.AccId == id);
            List<Transaction> trans = await applicationDbContext.ToListAsync();
            trans.Reverse();
            if (from==null || to==null)
            {
                return View(trans);
            }
            else
            {  
                List<Transaction> reTrans = new List<Transaction>();
                foreach(var tr in trans)
                {
                    if (tr.Date >= from && tr.Date <= to)
                        reTrans.Add(tr);
                }
                ViewData["Indicator"] = "Not null";
                return View(reTrans);
            }      
        }

        #endregion

        #region Create
        //CREATE CHECKING ACCOUNT 
        [Authorize]
        public IActionResult CreateChecking()
        {
            ViewData["CustomerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateChecking([Bind("Balance")] Checking account)
        {
            account.CustomerId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
            account.AccountNumber = NumberGenerator.rnd.Next(100000000, 1000000000);
            account.RoutingNumber = NumberGenerator.rnd.Next(10000000, 100000000);
            account.Interest = 0.02;
            account.IsActive = true;
            account.AccountType = "Checking";
            account.DateOpened = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();

                Transaction tran = new Transaction()
                {
                    AccId = account.Id,
                    Operation = "Open",
                    Amount = account.Balance,
                    Date = account.DateOpened
                };
                _context.Add(tran);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(GetChecking));
            }
            ViewData["CustomerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", account.CustomerId);
            return View(account);
        }



        //CREATE BUSINESS ACCOUNT 
        [Authorize]
        public IActionResult CreateBusiness()
        {
            ViewData["CustomerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateBusiness([Bind("Balance")] Business account)
        {
            account.CustomerId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
            account.AccountNumber = NumberGenerator.rnd.Next(100000000, 1000000000);
            account.RoutingNumber = NumberGenerator.rnd.Next(10000000, 100000000);
            account.Interest = 0.03;
            account.IsActive = true;
            account.AccountType = "Business";
            account.DateOpened = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();

                Transaction tran = new Transaction()
                {
                    AccId = account.Id,
                    Operation = "Open",
                    Amount = account.Balance,
                    Date = account.DateOpened
                };
                _context.Add(tran);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(GetBusiness));
            }
            ViewData["CustomerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", account.CustomerId);
            return View(account);
        }



        //CREATE LOAN ACCOUNT 
        [Authorize]
        public IActionResult CreateLoan()
        {
            ViewData["CustomerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateLoan([Bind("Balance", "DateClosed")] Loan account)
        {
            account.CustomerId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
            account.AccountNumber = NumberGenerator.rnd.Next(100000000, 1000000000);
            account.Interest = 0.05;
            account.IsActive = true;
            account.AccountType = "Loan";
            account.DateOpened = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();

                Transaction tran = new Transaction()
                {
                    AccId = account.Id,
                    Operation = "Open",
                    Amount = account.Balance,
                    Date = account.DateOpened
                };
                _context.Add(tran);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(GetLoan));
            }
            ViewData["CustomerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", account.CustomerId);
            return View(account);
        }




        //CREATE TERM DEPOSIT 
        [Authorize]
        public IActionResult CreateTermDeposit()
        {
            ViewData["CustomerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateTermDeposit([Bind("Balance", "DateClosed")] TermDeposit account)
        {
            account.CustomerId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
            account.AccountNumber = NumberGenerator.rnd.Next(100000000, 1000000000);
            account.Interest = 0.06;
            account.IsActive = true;
            account.AccountType = "TermDeposit";
            account.DateOpened = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();

                Transaction tran = new Transaction()
                {
                    AccId = account.Id,
                    Operation = "Open",
                    Amount = account.Balance,
                    Date = account.DateOpened
                };
                _context.Add(tran);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(GetTermDeposit));
            }
            ViewData["CustomerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", account.CustomerId);
            return View(account);
        }

        #endregion

        #region Deposit
        // GET: Deposit
        [Authorize]
        public async Task<IActionResult> Deposit(int? id, string msg)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["Message"] = msg;
            return View(account);
        }


        // POST: Deposit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Deposit(int id, double amount)
        {
            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    account.Balance += amount;
                    _context.Update(account);
                    await _context.SaveChangesAsync();

                    Transaction tran = new Transaction()
                    {
                        AccId = account.Id,
                        Operation = "Deposit",
                        Amount = amount,
                        Date = DateTime.Now
                    };
                    _context.Add(tran);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (account.AccountType == "Checking")
                    return RedirectToAction(nameof(GetChecking));
                else
                    return RedirectToAction(nameof(GetBusiness));
            }
        }
        #endregion

        #region Close
        // GET: Accounts/Close
        [Authorize]
        public async Task<IActionResult> Close(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }
            else if (account.AccountType == "Checking" || account.AccountType == "Business")
            {
                if (account.Balance != 0)
                    return Content("Can not close account with balance");
                return View(account);
            }
            else if (account.AccountType == "TermDeposit" || account.AccountType == "Loan")
            {
                if (DateTime.Now < account.DateClosed)
                    return Content("Can not close account before closing  date.");
                else if (account.Balance != 0)
                    return Content("Can not close account with balance");
                return View(account);
            }
            else
                return View(account);
        }


        // POST: Accounts/Close
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Close(int id)
        {
            var account = await _context.Account.FindAsync(id);
            account.IsActive = false;
            if (account.AccountType == "Checking" || account.AccountType == "Business")
                account.DateClosed = DateTime.Now;

            _context.Update(account);
            await _context.SaveChangesAsync();

            Transaction tran = new Transaction()
            {
                AccId = id,
                Operation = "Close",
                Amount = 0,
                Date = DateTime.Now
            };  
            _context.Add(tran);
            await _context.SaveChangesAsync();

            if (account.AccountType == "Checking")
                return RedirectToAction(nameof(GetChecking));
            else if (account.AccountType == "Business")
                return RedirectToAction(nameof(GetBusiness));
            else if (account.AccountType == "TermDeposit")
                return RedirectToAction(nameof(GetTermDeposit));
            else
                return RedirectToAction(nameof(GetLoan));
        }
        #endregion

        #region Withdraw
        // GET: Withdraw
        [Authorize]
        public async Task<IActionResult> Withdraw(int? id, string msg)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["Message"] = msg;
            return View(account);
        }


        // POST: Withdraw
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Withdraw(int id, double amount)
        {
            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    if (account.AccountType == "TermDeposit")
                    {
                        if (account.DateClosed > DateTime.Now)
                            return RedirectToAction("Withdraw", new { id = id, msg = "Can not withdraw before maturity date." });
                        else if (account.Balance < amount)
                            return RedirectToAction("Withdraw", new { id = id, msg="Insufficient Fund." }); 
                        else
                            account.Balance -= amount;
                    }
                    else if (account.AccountType == "Checking")
                    {
                        if (account.Balance < amount)
                            return RedirectToAction("Withdraw", new { id = id, msg = "Insufficient Fund." });
                        else
                            account.Balance -= amount;
                    }
                    else if (account.AccountType == "Business")
                        account.Balance -= amount;
                    else
                        return RedirectToAction("Withdraw", new { id = id, msg = "Invalid Action." });

                    _context.Update(account);
                    await _context.SaveChangesAsync();

                    Transaction tran = new Transaction()
                    {
                        AccId = account.Id,
                        Operation = "Withdraw",
                        Amount = amount,
                        Date = DateTime.Now
                    };
                    _context.Add(tran);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (account.AccountType == "Checking")
                    return RedirectToAction(nameof(GetChecking));
                else if (account.AccountType == "Business")
                    return RedirectToAction(nameof(GetBusiness));
                else
                    return RedirectToAction(nameof(GetTermDeposit));
            }
        }

        #endregion

        #region Transfer
        // GET: Accounts/Transfer
        [Authorize]
        public async Task<IActionResult> Transfer(int? id, string msg)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (account == null)
            {
                return NotFound();
            }
            string CustId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
            var Clist = await _context.Checking.Where(u => u.CustomerId == CustId && u.IsActive == true).ToListAsync();
            var Blist = await _context.Business.Where(u => u.CustomerId == CustId && u.IsActive == true).ToListAsync();

            AccountList list = new AccountList()
            {
                Act = account,
                CList = Clist,
                BList = Blist
            };
            ViewData["Message"] = msg;
            return View(list);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Transfer(int id, int idTo, double amount)
        {
            var accountFrom = await _context.Account.FindAsync(id);
            var accountTo = await _context.Account.FindAsync(idTo);

            if(accountFrom.AccountType == "TermDeposit")
            {
                if (DateTime.Now < accountFrom.DateClosed)
                    return RedirectToAction("Transfer", new { id = id, msg = "Can not withdraw before maturity date." });
                else if(accountFrom.Balance < amount)
                    return RedirectToAction("Transfer", new { id = id, msg = "Insufficient Fund." });
            }
            if(accountFrom.AccountType == "Checking")
            {
                if (accountFrom.Balance < amount)
                    return RedirectToAction("Transfer", new { id = id, msg = "Insufficient Fund." });
            }
            try
            {
                accountFrom.Balance -= amount;
                accountTo.Balance += amount;
                _context.Update(accountFrom);
                _context.Update(accountTo);
                await _context.SaveChangesAsync();

                Transaction tranF = new Transaction()
                {
                    AccId = id,
                    Operation = "Transfer Out",
                    Amount = amount,
                    Date = DateTime.Now
                };

                Transaction tranT = new Transaction()
                {
                    AccId = idTo,
                    Operation = "Transfer In",
                    Amount = amount,
                    Date = DateTime.Now
                };
                _context.Add(tranF);
                _context.Add(tranT);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountExists(accountFrom.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            if (accountFrom.AccountType == "Checking")
                return RedirectToAction(nameof(GetChecking));
            else if (accountFrom.AccountType == "Business")
                return RedirectToAction(nameof(GetBusiness));
            else
                return RedirectToAction(nameof(GetTermDeposit));
        }
        #endregion

        #region PayLoan
        // GET: Pay Loan
        [Authorize]
        public async Task<IActionResult> PayLoan(int? id, string msg)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (account == null)
            {
                return NotFound();
            }
            string CustId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
            var Clist = await _context.Checking.Where(u => u.CustomerId == CustId && u.IsActive == true).ToListAsync();
            var Blist = await _context.Business.Where(u => u.CustomerId == CustId && u.IsActive == true).ToListAsync();
            var Tlist = await _context.TermDeposit.Where(u => u.CustomerId == CustId && u.IsActive == true).ToListAsync();

            AccountList list = new AccountList()
            {
                Act = account,
                CList = Clist,
                BList = Blist,
                TList = Tlist
            };
            ViewData["Message"] = msg;
            return View(list);
        }


        // POST: PayLoan
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> PayLoan(int id, int idPay, double amount)
        {
            var loanAcc = await _context.Account.FindAsync(id);
            var payAcc = await _context.Account.FindAsync(idPay);
            if(loanAcc.Balance < amount)
                return RedirectToAction("PayLoan", new { id = id, msg = "Can not overpay." });
            if (payAcc.AccountType == "TermDeposit")
            {
                if (DateTime.Now < payAcc.DateClosed)
                    return RedirectToAction("PayLoan", new { id = id, msg = "Can not withdraw before maturity date." });
                else if (payAcc.Balance < amount)
                    return RedirectToAction("PayLoan", new { id = id, msg = "Can not overdraw." });
            }
            if (payAcc.AccountType == "Checking")
            {
                if (payAcc.Balance < amount)
                    return RedirectToAction("PayLoan", new { id = id, msg = "Can not overdraw." });
            }
            try
            {
                payAcc.Balance -= amount;
                loanAcc.Balance -= amount;
                _context.Update(loanAcc);
                _context.Update(payAcc);
                await _context.SaveChangesAsync();

                Transaction tranL = new Transaction()
                {
                    AccId = id,
                    Operation = "Loan Payment In",
                    Amount = amount,
                    Date = DateTime.Now
                };

                Transaction tranP = new Transaction()
                {
                    AccId = idPay,
                    Operation = "Loan Payment Out",
                    Amount = amount,
                    Date = DateTime.Now
                };
                _context.Add(tranL);
                _context.Add(tranP);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountExists(loanAcc.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(GetLoan));
        }
        #endregion

        #region About & Contact
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }



        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.Id == id);
        }
        #endregion
    }
}

