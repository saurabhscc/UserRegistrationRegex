using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public const string MOBILENUMBER = "^[1-9]{1}[0-9]{1}\\s[1-9]{1}[0-9]{9}$";
        /// Valid Predefined mobile number of user
        /// </summary>
        /// <returns></returns>
        public static bool ValidateMobileNumber()
        {
            Regex regex = new Regex(MOBILENUMBER);
            return regex.IsMatch("91 9919819801");
        }
    }
}
