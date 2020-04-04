using BankSystem_PCL.Implementation.Services.BankServices.DepositService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public class BankService
    {
        public static readonly SafeService _safeService = SafeService.Instance;
        public static IHandler _handled;
        public static ITransaction _operation;

        public void HandleUser(IUser user)
        {
            IHandler goldMemberHandler = new GoldHandler();
            IHandler silverMemberHandler = new SilverHandler();
            IHandler bronzeMemberHandler = new BronzeHandler();

            goldMemberHandler.Successor = silverMemberHandler;
            silverMemberHandler.Successor = bronzeMemberHandler;
            bronzeMemberHandler.Successor = null;

            goldMemberHandler.SetSuccessor(user);
            _handled = goldMemberHandler.SetSuccessor(user);
            _operation = _handled.HandleUser(user);
        }


        public static void MakeOperation(IUser user, ITransaction operation)
        {
            if (operation.GetType() == typeof(LoanForBronzeMember) || operation.GetType() == typeof(LoanForGoldMember) || operation.GetType() == typeof(LoanForSilverMember))
            {
                _safeService.LoanGranting(user, operation);
                Console.WriteLine($"Your Loan Parameters => Date: {operation.Date}, AccountId: {operation.AccountId}, Amont of money: {operation.Money}");
                Console.WriteLine("Thank you for choosing our service!");
            }
            else if((operation.GetType() == typeof(DepositForGoldMember)) || ((operation.GetType() == typeof(DepositForBronzeMember)) || (operation.GetType() == typeof(DepositForSilverMember))))
             {
                _safeService.DepositeIssuing(user, operation);
                Console.WriteLine($"Your Loan Parameters => Date: {operation.Date}, AccountId: {operation.AccountId}, Amont of money: {operation.Money}");
                Console.WriteLine("Thank you for choosing our service!");
            }
        }

    }
}