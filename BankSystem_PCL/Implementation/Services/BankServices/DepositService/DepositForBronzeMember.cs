using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_PCL.Implementation.Services.BankServices.DepositService
{
    public class DepositForBronzeMember : IDeposit
    {
        public int MoneyLimit { get; set; } = 2000;
        public int Tenure { get; set; } = 2;
        public int InterestRate { get; set; } = 2;
        public string AccountId { get; set; }
        public DateTime Date { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }

        public string GetDepositInfo()
        {
            return $"You can deposit your cash here for {Tenure} years, the Interest rate is {InterestRate}% and the limit of the cash is {MoneyLimit}$";
        }
    }
}
