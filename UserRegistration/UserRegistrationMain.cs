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
        public string MAILID = "[A-Za-z0-9]+[A-Za-z]+.[a-z]{2,4}$";
        public string MOBILENO = "^[91]+[ ]+[6-9][0-9]{9}$";

        public bool firstNameValidater(string firstName)
        {
            return Regex.Match(firstName, NAMEPATTERN).Success;
        }

        public bool lastNameValidater(string lastNmae)
        {
            return Regex.Match(lastNmae, NAMEPATTERN).Success;
        }

        public bool mailIdValidater(string mailId)
        {
            return Regex.Match(mailId, MAILID).Success;
        }

        public bool mobieNoValidater(string mailId)
        {
            return Regex.Match(mailId, MAILID).Success;
        }
    }
}
