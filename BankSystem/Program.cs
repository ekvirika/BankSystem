using BankSystem_PCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        
        {
            BankService bank = new BankService();
            IUser elene = new GoldMember() { Name = "Elene", Surname = "Kvirikashvili", AccoundID = "ABC545", Money = 8000 };

            bank.HandleUser(elene);



            Console.ReadKey();
        }
    }
}
