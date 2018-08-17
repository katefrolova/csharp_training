using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {

        [Test]
        public void ContactCreationTTest()
        {
            ContactData contact = new ContactData("ww","tt");
            app.Contacts.CreateContact(contact);
        }

    }
}
