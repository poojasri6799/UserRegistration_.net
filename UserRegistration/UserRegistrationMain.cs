using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistrationMain
    {

        /// <summary>
        ///name regular expression pattern
        /// </summary>
        public string NAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";


        /// <summary>
        /// Mail regular expression pattern
        /// </summary>
        public string MAILID = "^[a-zA-Z0-9]+([._+#-][a-zA-Z0-9]+)*@[a-zA-Z1-9]+.[a-zA-Z]{2,4}(.[a-zA-Z]{2,3})?$";


        /// <summary>
        /// Phone number regular expression pattern
        /// </summary>
        public string MOBILENO = "^[91]+[ ]+[6-9]+[0-9]{9}$";
       

        /// <summary>
        /// Password regular expression pattern
        /// </summary>
        public string PASSWORD = "^[0-9A-Za-z]*[!@#$%&,.?][A-Za-z0-9]*$";


        /// <summary>
        /// function for name validater
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public bool firstNameValidater(string firstName)
        {
            return Regex.Match(firstName, NAMEPATTERN).Success;
        }

        /// <summary>
        /// function for last name validater
        /// </summary>
        /// <param name="lastNmae"></param>
        /// <returns></returns>
        public bool lastNameValidater(string lastNmae)
        {
            return Regex.Match(lastNmae, NAMEPATTERN).Success;
        }

        /// <summary>
        /// function for mail id 
        /// </summary>
        /// <param name="mailId"></param>
        /// <returns></returns>
        public bool mailIdValidater(string mailId)
        {
            return Regex.Match(mailId, MAILID).Success;
        }

        /// <summary>
        /// function for phone number
        /// </summary>
        /// <param name="phoneNo"></param>
        /// <returns></returns>
        public bool PhoneNumberValidater(string phoneNo)
        {
            return Regex.Match(phoneNo, MOBILENO).Success;
        }

        /// <summary>
        /// function for password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool passwordValidater(string password)
        {
            return Regex.Match(password, PASSWORD).Success;
        }
    }
}
