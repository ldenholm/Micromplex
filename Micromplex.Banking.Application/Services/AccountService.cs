using Micromplex.Banking.Application.Interfaces;
using Micromplex.Banking.Application.Models;
using Micromplex.Banking.Domain.Commands;
using Micromplex.Banking.Domain.Interfaces;
using Micromplex.Banking.Domain.Models;
using Micromplex.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;
        private readonly IEventBus _eventBus;
        
        public AccountService(IAccountRepository repo, IEventBus eventBus)
        {
            _repo = repo;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _repo.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.Source,
                accountTransfer.Target,
                accountTransfer.Amount
                );

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
