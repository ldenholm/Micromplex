using Micromplex.Transfer.Application.Interfaces;
using Micromplex.Transfer.Domain.Interfaces;
using Micromplex.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Micromplex.Domain.Core.Bus;

namespace Micromplex.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepo;
        private readonly IEventBus _eventBus;
        
        public TransferService(ITransferRepository transferRepo, IEventBus eventBus)
        {
            _transferRepo = transferRepo;
            _eventBus = eventBus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepo.GetTransferLogs();
        }
    }
}
