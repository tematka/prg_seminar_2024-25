using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class BankAccount
    {
        int balance;
        public string currency = "CZK";

        public void Test()
        {
            Console.WriteLine(currency);
        }
    }
}
