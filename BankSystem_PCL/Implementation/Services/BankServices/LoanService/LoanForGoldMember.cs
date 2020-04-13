using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public class LoanForGoldMember : ILoanService, ILoan
    {
        public int YearsToPay { get; set; } = 10;
        public int InterestRate { get; set; } = 5;
        public int MoneyLimit { get; set; } = 10000;
        public string AccountId { get; set; }
        public DateTime Date { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }



        public string GetLoanInfo()
        {
            return $"The duration of the Loan is {YearsToPay} years, in the Interest rate of {InterestRate}%.SS Amount of the loan for Gold Membership is {MoneyLimit}$";
        }
    }
}