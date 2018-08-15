using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData contact = new ContactData("d", "dd");
            contact.Bday = "14";
            contact.Bmonth = "December";
            contact.Aday = "17";
            contact.Amonth = "December";
            app.Contacts.ContactModify(2, contact);
            app.Auth.Logout();
        }
    }
}
