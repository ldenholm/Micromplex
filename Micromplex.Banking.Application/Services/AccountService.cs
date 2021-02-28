using Micromplex.Banking.Application.Interfaces;
using Micromplex.Banking.Domain.Interfaces;
using Micromplex.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;
        
        public AccountService(IAccountRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _repo.GetAccounts();
        }
    }
}
