using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public const string PASSWORDRULE2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        /// Validate Password rule 2,should have at least 1 Uppercase with Min.8 Characters 
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePasswordR2()
        {
            Regex regex = new Regex(PASSWORDRULE2);
            return regex.IsMatch("Sairam77");
        }
    }
}
