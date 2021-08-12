using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public const string EMAILID = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@][a-zA-z]+([.][a-z]{2,3})*$";
        /// <summary>
        /// Valid Emailid of user
        /// </summary>
        /// <returns></returns>
        public static bool ValidateEmailId()
        {
            Regex regex = new Regex(EMAILID);
            return regex.IsMatch("abc.xyz@bl.co.in");
        }
    }
}
