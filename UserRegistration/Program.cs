﻿using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool details = UserValidation.ValidateFirstName();
            Console.WriteLine(details);
        }
    }
}