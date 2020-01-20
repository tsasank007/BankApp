using System;

namespace BankTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //we are creating a variable
            var myAct = new Account();
            myAct.AccountNumber = 5582397;
            myAct.AccountType = "Checking";

        }
    }
}
