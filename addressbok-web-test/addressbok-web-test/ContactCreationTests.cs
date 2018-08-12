using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void ContactCreationTTest()
        {
            GoToHomePage();
            Login(new AccountData("admin","secret"));
            InitContactsCreation();
            ContactData contact = new ContactData("ww","tt");
            contact.Bday = "4";
            contact.Bmonth = "March";
            contact.Aday = "7";
            contact.Amonth = "December";
            contact.NewGroup = "aaa";
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToHomePage();
            Logout();
        }


    }
}
