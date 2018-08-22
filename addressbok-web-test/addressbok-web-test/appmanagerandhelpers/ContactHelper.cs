using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) 
            :base(manager)
        {
           // this.driver = driver;
        }

        public ContactHelper CreateContact(ContactData contact)
        {
           InitContactsCreation();
           FillContactForm(contact);
           SubmitContactCreation();
           ReturnToHomePage();
           return this;
        }

        public List<ContactData> GetContactList()
        {
            List<ContactData> contacts = new List<ContactData>();
            manager.Navigator.GoToHomePage();
            ICollection<IWebElement> elementsFirstName = driver.FindElements(By.XPath(".//*[@id='maintable']/tbody/tr/td[3]"));
            ICollection<IWebElement> elementsLastName = driver.FindElements(By.XPath(".//*[@id='maintable']/tbody/tr/td[2]"));
            //foreach (IWebElement element in elements)
            //{
            //    //GroupData group = new GroupData(element.Text);
            //    contacts.Add(new ContactData(element.Text));
            //}
            for (int i = 0; i < elementsFirstName.Count; i++)
            {
                contacts.Add(new ContactData(elementsFirstName.ElementAt<IWebElement>(i).Text, elementsLastName.ElementAt<IWebElement>(i).Text));
            }
            return contacts;
        }

        public ContactHelper DriverAlert()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper NoContactsCreated()
        {
            if (!IsElementPresent(By.Name("selected[]")))
            {
                CreateContact(new ContactData("tt", "zz"));
            }
            return this;
        }

        public ContactHelper ContactDelete(int l)
        {
            manager.Navigator.GoToHomePage();
            SelectContact(l);
            RemoveContact();
            DriverAlert();
            return this;
        }

        public ContactHelper ContactModify(int p, ContactData contact)
        {
            manager.Navigator.GoToHomePage();
            InitContactModification(p);
            FillContactForm(contact);
            SubmitContactModification();
            manager.Navigator.GoToHomePage();
            return this;
        }


        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Secondname);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("photo"), contact.Photo);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Home);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("work"), contact.Work);
            Type(By.Name("fax"), contact.Fax);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("homepage"), contact.Homepage);
            Type(By.Name("address2"), contact.Address2);
            Type(By.Name("phone2"), contact.Phone2);
            Type(By.Name("notes"), contact.Notes2);
            return this;
        }

        public ContactHelper InitContactsCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }


        public ContactHelper SelectContact(int v)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + v + "]")).Click();
            return this;
        }

        public ContactHelper InitContactModification(int t)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + t + "]")).Click();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            return this;
        }
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

    }
}
