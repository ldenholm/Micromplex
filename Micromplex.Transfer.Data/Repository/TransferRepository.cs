using Micromplex.Transfer.Data.Context;
using Micromplex.Transfer.Domain.Interfaces;
using Micromplex.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;
        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public void Add(TransferLog transferLog)
        {
            _context.Add(transferLog);
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs;
        }
    }
}
