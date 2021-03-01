using Micromplex.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
