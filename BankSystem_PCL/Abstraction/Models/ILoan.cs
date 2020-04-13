using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public interface ILoan : ITransaction
    {
        int YearsToPay { get; set; }
        int InterestRate { get; set; }
        int MoneyLimit { get; set; }

    }
}