﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class ContactData
    {
        private string firstname;
        private string secondname = "";

        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }

        public ContactData(string firstname, string secondname)
        {
            this.firstname = firstname;
            this.secondname = secondname;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Secondname
        {
            get
            {
                return secondname;
            }
            set
            {
                secondname = value;
            }
        }
    }
}
