using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public interface IDeposit : ITransaction
    {
        int MoneyLimit { get; set; }
        int Tenure { get; set; }
        int InterestRate { get; set; }
        string GetDepositInfo();
    }
}