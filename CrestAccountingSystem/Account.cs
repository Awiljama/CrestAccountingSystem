using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace CrestAccountingSystem
{
    public class Account
    {
        private const int ACCOUNT_NUMBER_MINIMUM = 1000000;
        private const int ACCOUNT_NUMBER_MAXIMUM = 9999999;
        public AccountContact ContactInformation { get; private set; }
        public int AccountNumber { get; private set; }

        public Account(AccountContact contactInformation)
        {
            ContactInformation = contactInformation;
            AccountNumber = GenerateNewAccountNumber();
        }

        private int GenerateNewAccountNumber()
        {
            var random = new Random();
            return random.Next(ACCOUNT_NUMBER_MINIMUM, ACCOUNT_NUMBER_MAXIMUM);
        }
    }
}
