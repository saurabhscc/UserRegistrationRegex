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
        //public const string PASSWORDRULE1 = "^.{8,}$";
        //public const string PASSWORDRULE2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        //public const string PASSWORDRULE3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string PASSWORD = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
        public const string EMAIL_SAMPLE = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";


        /// <summary>
        /// Valid first name of user
        /// </summary>
        /// <returns></returns>
        public static string ValidateFirstName(string firstname)
        {
            Regex regex = new Regex(FIRSTNAME);
            try
            {
                if (regex.IsMatch(firstname))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_FIRST_NAME, "First name is not valid");
            }
        }
        /// <summary>
        /// valid last name of user
        /// </summary>
        /// <returns></returns>
        public static string ValidateLastName(string lastname)
        {
            Regex regex = new Regex(LASTNAME);
            try
            {
                if (regex.IsMatch(lastname))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_LAST_NAME, "Last name is not valid");
            }
        }
        /// <summary>
        /// valid emailid of user
        /// </summary>
        /// <returns></returns>
        public static string ValidateEmailId(string emailid)
        {
            Regex regex = new Regex(EMAILID);
            try
            {
                if (regex.IsMatch(emailid))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAILID, "Email name is not valid");
            }
        }
        /// valid predefined mobile number of user
        /// </summary>
        /// <returns></returns>
        public static string ValidateMobileNumber(string mobilenumber)
        {
            Regex regex = new Regex(MOBILENUMBER);
            try
            {
                if (regex.IsMatch(mobilenumber))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MOBILENUMBER, "Mobile Number is not valid");
            }
        }

        public static string ValidatePassword(string password)
        {
            Regex regex = new Regex(PASSWORD);
            try
            {
                if (regex.IsMatch(password))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "Password is not valid");
            }
        }

            public static void ValidatingEmail()
            {
                string[] sample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc@.com","abc123@gmail.a", "abc123@.com" ,
                                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};
                Regex regex = new Regex(EMAIL_SAMPLE);
                Console.WriteLine("Validate the  Email ID's");
                Console.WriteLine("=========================");

                ValidateEmail(sample,regex);
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
                        Console.WriteLine(arr[i] + "------->" + "Valid EmailID");
                    else
                        Console.WriteLine(arr[i] + "-------->" + "Invalid EmailID");
                }
            }
        }
    }

