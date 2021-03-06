﻿using Micromplex.Banking.Application.Models;
using Micromplex.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
