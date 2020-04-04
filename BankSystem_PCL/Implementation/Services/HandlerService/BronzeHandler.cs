using BankSystem_PCL.Implementation.Services.BankServices.DepositService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public class BronzeHandler : IHandler
    {
        public IHandler Successor { get; set; }

        public IHandler SetSuccessor(IUser user)
        {
            IHandler handled = (user is BronzeMember) ? new BronzeHandler() : Successor.SetSuccessor(user);
            return handled;
        }

        public ITransaction HandleUser(IUser user)
        {
            ITransaction operation;
            Console.WriteLine($"{this.GetType().Name} handled {user.Name} {user.Surname}");
            Console.WriteLine("Do you want to 1. Get Loan or 2.Issue Deposit?");
            var choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the amount of money:");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the password:");
            string password = Console.ReadLine();
            operation = (choice == 1) ? user.GetLoan(password, money) : user.DepositCash(password, money);
            BankService.MakeOperation(user, operation);
            return operation;
        }
    }
}