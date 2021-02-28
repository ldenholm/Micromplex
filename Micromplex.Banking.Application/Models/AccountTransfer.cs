using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int Source { get; set; }
        public int Target { get; set; }
        public decimal Amount { get; set; }
    }
}
