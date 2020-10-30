using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistrationMain
    {
        public string NAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public bool firstNameValidater(string firstName)
        {
            return Regex.Match(firstName, this.NAMEPATTERN).Success;
        }
    }
}
