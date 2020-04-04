using BankSystem_PCL.Implementation.Services.BankServices.DepositService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public class BronzeMember : IUser
    {
        public string Name { get; set; }
        public string Surname { get; set ; }
        public string AccoundID { get; set; }
        public int Money { get; set; }
        public List<ITransaction> Transactions { get; set; } = new List<ITransaction>();
        public List<ILoan> LoanHistory { get; set; } = new List<ILoan>();
        public List<IDeposit> DepositHistory { get; set; } = new List<IDeposit>();


        public ITransaction GetLoan(string password, int money)
        
        {
            LoanForBronzeMember loan = null;
            if (this.Money > money) // შეამოწმებს კლიენტის მიერ შეყვანილ თანხას, თუ მეტია (ანუ თუ აქვს კლიენტს სესხის გადახდის სახსრები), ამ შემთვევაში შესთავაზებს სესხის პირობებს შესაბამისი მემბერშიფისთვის
            {
                loan = new LoanForBronzeMember()
                {
                    AccountId = this.AccoundID,
                    Password = password,
                    Date = DateTime.Now,
                    Money = money
                };
                Money += money;
                LoanHistory.Add(loan);
                Transactions.Add(loan);
            }
            return loan;
        }

        public ITransaction DepositCash(string password, int money)
        {
            DepositForBronzeMember deposit = null;
            if(this.Money > money)
            {
                deposit = new DepositForBronzeMember()
                {
                    AccountId = this.AccoundID,
                    Password = password,
                    Date = DateTime.Now,
                    Money = money
                };
                Money -= deposit.Money;
                DepositHistory.Add(deposit);
                Transactions.Add(deposit);
            }
            return deposit;
        }
    }
}