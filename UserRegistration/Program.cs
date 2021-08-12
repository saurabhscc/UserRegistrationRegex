using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool details = UserValidation.ValidatePasswordR2();
            Console.WriteLine(details);
        }
    }
}
