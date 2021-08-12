using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public const string PASSWORDRULE3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        /// Validate Password rule 3,should have at least 1 Numeric & Uppercase each with Min.8 Characters 
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePasswordR3()
        {
            Regex regex = new Regex(PASSWORDRULE3);
            return regex.IsMatch("Sairam77");
        }
    }
}
