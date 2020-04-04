using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public class SafeService
    {
        private static SafeService _instance = default;

        private List<ITransaction> _allTransactions = new List<ITransaction>();
        public long _budget = 1000000000000000;

        private SafeService(){ }

        public static SafeService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SafeService();
                }
                return _instance;
            }
        }

        public void LoanGranting(IUser user, ITransaction loan)
        {
            loan = user.GetLoan(loan.Password, loan.Money);
            if(loan != null)
            {
                _budget -= loan.Money;
                _allTransactions.Add(loan);
            }
        }

        public void DepositeIssuing(IUser user, ITransaction deposit)
        {
            deposit = user.DepositCash(deposit.Password, deposit.Money);
            if (deposit != null)
            {
                _budget += deposit.Money;
                _allTransactions.Add(deposit);
            }
        }
    }
}