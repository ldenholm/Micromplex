using Micromplex.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
