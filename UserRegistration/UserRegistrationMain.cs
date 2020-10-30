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


        //Mail regular expression pattern
        public string MAILID = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)?@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})?$";


        //Phone number regular expression pattern
        public string MOBILENO = "^[91]+[ ]+[6-9][0-9]{9}$";


        //Password regular expression pattern
        public string PASSWORD = "^[0-9A-Za-z]*[!@#$%&,.?][A-Za-z0-9]*$";

        
        //function for name
        public bool firstNameValidater(string firstName)
        {
            return Regex.Match(firstName, NAMEPATTERN).Success;
        }

        //function for name
        public bool lastNameValidater(string lastNmae)
        {
            return Regex.Match(lastNmae, NAMEPATTERN).Success;
        }

        //function for mail
        public bool mailIdValidater(string mailId)
        {
            return Regex.Match(mailId, MAILID).Success;
        }

        //function for phone number
        public bool PhoneNumberValidater(string phoneNo)
        {
            return Regex.Match(phoneNo, MOBILENO).Success;
        }

        //function for password
        public bool minimumEightValidater(string minEight)
        {
            return Regex.Match(minEight, PASSWORD).Success;
        }

        //function for password
        public bool minimumUpperCase(string upperCase)
        {
            return Regex.Match(upperCase, PASSWORD).Success;
        }

        //function for password
        public bool numericValidater(string numericNumber)
        {
            return Regex.Match(numericNumber, PASSWORD).Success;
        }

        //function for password
        public bool specialCharValidater(string specialChar)
        {
            return Regex.Match(specialChar, PASSWORD).Success;
        }
    }
}
