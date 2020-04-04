using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public interface IUser
    {
        string Name { get; set; }
        string Surname { get; set; }
        string AccoundID { get; set; }
        int Money { get; set; }
        List<ITransaction> Transactions { get; set; }
        List<ILoan> LoanHistory { get; set; }
        List<IDeposit> DepositHistory { get; set; }
        ITransaction GetLoan(string password, int money);
        ITransaction DepositCash(string password, int money);
    }
}