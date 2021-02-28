using Micromplex.Banking.Data.Context;
using Micromplex.Banking.Domain.Interfaces;
using Micromplex.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _context;
        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
