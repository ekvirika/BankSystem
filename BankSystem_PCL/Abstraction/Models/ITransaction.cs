using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public interface ITransaction 
    {
        string AccountId { get; set; }
        DateTime Date { get; set; }
        string Password { get; set; }
        int Money { get; set; }
    }
}