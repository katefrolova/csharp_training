using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Mapping;

namespace WebAddressbookTests
{
    public class AddressBookDB: LinqToDB.Data.DataConnection
    {
        public AddressBookDB(): base("AddressBool") { }

        public ITable<GroupData> Groups { get { return GetTable<GroupData>(); } }
        public ITable<GroupData> Contacts { get { return GetTable<ContactData>(); } }
    }
}
