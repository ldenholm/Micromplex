using Micromplex.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
