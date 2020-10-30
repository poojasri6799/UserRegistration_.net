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
        public string MAILID = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)?@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})?$";
        public string MOBILENO = "^[91]+[ ]+[6-9][0-9]{9}$";
        public string PASSWORD = "^([A-Z]{1,})*([(@#$*)-])*[a-zA-Z0-9]{6,}$";

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

        public bool PhoneNumberValidater(string phoneNo)
        {
            return Regex.Match(phoneNo, MOBILENO).Success;
        }

        public bool minimumEightValidater(string minEight)
        {
            return Regex.Match(minEight, PASSWORD).Success;
        }
    }
}
