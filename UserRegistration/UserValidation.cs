using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public const string EMAIL_SAMPLE = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public static void ValidatingEmail()
        {
            string[] sample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc@.com","abc123@gmail.a", "abc123@.com" ,
                                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};
            Regex regex = new Regex(EMAIL_SAMPLE);
            Console.WriteLine("Validate the  Email ID's");
            Console.WriteLine("=========================");

            Validate(sample, regex);
        }
        /// <summary>
        /// printing email id status
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="regex"></param>
        public static void Validate(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool rs = regex.IsMatch(arr[i]);
                if (rs == true)
                    Console.WriteLine(arr[i] + "\t------->\t" +  "Valid EmailID");
                else
                    Console.WriteLine(arr[i] + "\t-------->\t" + "Invalid EmailID");
            }
        }
    }
}
