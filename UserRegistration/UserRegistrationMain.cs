using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistrationMain
    {
        //Name regular expression pattern
        public string NAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";



        public bool firstNameValidater(string firstName)
        {
            return Regex.Match(firstName, NAMEPATTERN).Success;
        }

        public bool lastNameValidater(string lastNmae)
        {
            return Regex.Match(lastNmae, NAMEPATTERN).Success;
        }
    }
}
