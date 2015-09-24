using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace CrestAccountingSystem
{
    public class CrestAccountingModel : DataContext
    {
        public Table<Account> Accounts;
        public CrestAccountingModel(string connection) : base(connection) { }
    }
}
