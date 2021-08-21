using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {
        public const string FIRSTNAME = "^[A-Z]{1}[a-z]{2}";
        public const string LASTNAME = "^[A-Z]{1}[a-z]{2}";
        public const string EMAILID = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@][a-zA-z]+([.][a-z]{2,3})*$";
        public const string MOBILENUMBER = "^[1-9]{1}[0-9]{1}\\s[1-9]{1}[0-9]{9}$";
        public const string PASSWORDRULE1 = "^.{8,}$";
        public const string PASSWORDRULE2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public const string PASSWORDRULE3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string PASSWORDRULE4 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
        public const string EMAIL_SAMPLE = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";


        /// <summary>
        /// Valid first name of user
        /// </summary>
        /// <returns></returns>
        public static bool ValidateFirstName()
        {
            Regex regex = new Regex(FIRSTNAME);
            return regex.IsMatch("Virat");
        }
        /// <summary>
        /// Valid Last name of user
        /// </summary>
        /// <returns></returns>
        public static bool ValidateLastName()
        {
            Regex regex = new Regex(LASTNAME);
            return regex.IsMatch("Kohli");
        }
        /// <summary>
        /// Valid Emailid of user
        /// </summary>
        /// <returns></returns>
        public static bool ValidateEmailId()
        {
            Regex regex = new Regex(EMAILID);
            return regex.IsMatch("abc.xyz@bl.co.in");
        }
        /// Valid Predefined mobile number of user
        /// </summary>
        /// <returns></returns>
        public static bool ValidateMobileNumber()
        {
            Regex regex = new Regex(MOBILENUMBER);
            return regex.IsMatch("91 9919819801");
        }
        /// Validate Password rule 1,should have Minimum 8 Characters
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePasswordR1()
        {
            Regex regex = new Regex(PASSWORDRULE1);
            return regex.IsMatch("sairam77");
        }
        /// Validate Password rule 2,should have at least 1 Uppercase with Min.8 Characters 
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePasswordR2()
        {
            Regex regex = new Regex(PASSWORDRULE2);
            return regex.IsMatch("Sairam77");
        }
        /// Validate Password rule 3,should have at least 1 Numeric & Uppercase each with Min.8 Characters 
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePasswordR3()
        {
            Regex regex = new Regex(PASSWORDRULE3);
            return regex.IsMatch("Sairam77");
        }
        /// Validate Password rule 3,should have at least 1 special char,1 Numeric & Uppercase each with Min.8 Characters 
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePasswordR4()
        {
            Regex regex = new Regex(PASSWORDRULE4);
            return regex.IsMatch("Sai@ram77");
        }

        public static void ValidatingEmail()
        {
            string[] sample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc@.com","abc123@gmail.a", "abc123@.com" ,
                                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};
            Regex regex = new Regex(EMAIL_SAMPLE);
            Console.WriteLine("Validate the  Email ID's");
            Console.WriteLine("=========================");

            ValidateEmail(sample, regex);
        }
        /// <summary>
        /// printing email id status
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="regex"></param>
        public static void ValidateEmail(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool rs = regex.IsMatch(arr[i]);
                if (rs == true)
                    Console.WriteLine(arr[i] + "------->" +  "Valid EmailID");
                else
                    Console.WriteLine(arr[i] + "-------->" + "Invalid EmailID");
            }
        }
    }
}
