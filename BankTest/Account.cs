using System;
using System.Collections.Generic;
using System.Text;

namespace BankTest
{
    class Account
    {
        public int AccountNumber { get; set; }
        public int Balance { get; private set; }
        public String AccountType { get; set; }
        public String email { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
