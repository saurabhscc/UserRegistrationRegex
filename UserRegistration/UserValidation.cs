using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public const string PASSWORDRULE1 = "^.{8,}$";
        /// Validate Password rule 1,should have Minimum 8 Characters
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePasswordR1()
        {
            Regex regex = new Regex(PASSWORDRULE1);
            return regex.IsMatch("sairam77");
        }
    }
}
