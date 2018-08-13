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
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin","secret"));
            app.Contacts.InitContactsCreation();
            ContactData contact = new ContactData("ww","tt");
            contact.Bday = "4";
            contact.Bmonth = "March";
            contact.Aday = "7";
            contact.Amonth = "December";
            contact.NewGroup = "aaa";
            app.Contacts.FillContactForm(contact);
            app.Contacts.SubmitContactCreation();
            app.Contacts.ReturnToHomePage();
            app.Auth.Logout();
        }


    }
}
