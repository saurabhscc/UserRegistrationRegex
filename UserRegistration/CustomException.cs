using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_MOBILENUMBER,
            INVALID_PASSWORD,
            INVALID_EMAILID

        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
