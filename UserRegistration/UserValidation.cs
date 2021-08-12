using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public const string FIRSTNAME = "^[A-Z]{1}[a-z]{2}";
        /// <summary>
        /// Valid first name of user
        /// </summary>
        /// <returns></returns>
        public static bool ValidateFirstName()
        {
            Regex regex = new Regex(FIRSTNAME);
            return regex.IsMatch("Virat");
        }
    }
}
