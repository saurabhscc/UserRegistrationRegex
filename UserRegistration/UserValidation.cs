using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public const string LASTNAME = "^[A-Z]{1}[a-z]{2}";
        /// <summary>
        /// Valid Last name of user
        /// </summary>
        /// <returns></returns>
        public static bool ValidateLastName()
        {
            Regex regex = new Regex(LASTNAME);
            return regex.IsMatch("Kohli");
        }
    }
}
