using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrestAccountingSystem
{
    public class AccountContact
    {
        public string AccountEmail { get; private set; }
        public string PhoneNumber { get; private set; }
        public string AccountName { get; private set; }
        public string AccountContactName { get; private set; }
        
        public AccountContact(string accountName, string accountContactName, string phoneNumber, string accountEmail)
        {
            AccountName = accountName;
            AccountContactName = accountContactName;
            PhoneNumber = phoneNumber;
            AccountEmail = accountEmail;
        }    
    }
}
