using BankSystem_PCL.Implementation.Services.BankServices.DepositService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public class LoanForBronzeMember : ILoanService, ILoan
    {
        public int YearsToPay { get; set; } = 1;
        public int InterestRate { get; set; } = 20;
        public int MoneyLimit { get; set; } = 2000;
        public string AccountId { get; set; }
        public DateTime Date { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }

        public string GetLoanInfo()
        {
            return $"The duration of the Loan is {YearsToPay} years, in the Interest rate of {InterestRate}%. Amount of the loan for Bronze Membership is {MoneyLimit}$";
        }
    }
}