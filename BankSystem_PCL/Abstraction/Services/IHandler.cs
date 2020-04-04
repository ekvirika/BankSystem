using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem_PCL
{
    public interface IHandler
    {
        IHandler Successor { get; set; }

        IHandler SetSuccessor(IUser user);
        ITransaction HandleUser(IUser user);
    }
}