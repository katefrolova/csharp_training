using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            app.Contacts.NoContactsCreated();
            ContactData contact = new ContactData("d", "dd");
            contact.Middlename = null;
            app.Contacts.ContactModify(1, contact);
        }
    }
}
