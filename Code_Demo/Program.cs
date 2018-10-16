using System;

using System.Text.RegularExpressions;

namespace ValidationLab
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = nameValidation();
            Console.WriteLine("Thanks! " + userName + ", What is your email?");
            string userEmail = emailValidation();
            Console.WriteLine("Thank you " + userName + ", What is your phone number?");
            string userPhone = phoneValidation();
            Console.WriteLine("What is your date or birth " + userName + "? Please enter in dd/mm/yyyy");
            string userDateOfBirth = birthValidation();
            Console.WriteLine("Thank you for the information " + userName);
        }

        public static string nameValidation()
        {
            Console.WriteLine("What is your name?");
            // input
            string userName = Console.ReadLine();

            // processing

            while (!Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,30}$"))
            {
                Console.WriteLine("I'm sorry! Thats not a name");
                userName = Console.ReadLine();
            }

            //output
            return userName;
        }

        public static string emailValidation()
        {

            // input
            string userEmail = Console.ReadLine();

            // processing

            while (!Regex.IsMatch(userEmail, @"^([A-z0-9]{5,30})@([A-z0-9]{5,10}).([A-z0-9]{2,3})$"))
            {
                Console.WriteLine("I'm sorry! That is not an email");
                userEmail = Console.ReadLine();

            }

            //output
            return userEmail;
        }

        public static string phoneValidation()
        {
            // input
            string userPhone = Console.ReadLine();

            // processing

            while (!Regex.IsMatch(userPhone, @"^\d\d\d-\d\d\d-\d\d\d\d$"))
            {
                Console.WriteLine("I'm sorry! Thats not a valid phone number, try again");
                userPhone = Console.ReadLine();
            }

            //output
            return userPhone;
        }
        public static string birthValidation()
        {

            // input
            string userDateOfBirth = Console.ReadLine();

            // processing

            while (!Regex.IsMatch(userDateOfBirth, @"^((0[1-9]|[12]\d|31)(-|\/)(0[13456789]|1[012])(-|\/)((19|[2-9]\d)\d{2}))$"))
            {
                Console.WriteLine("I'm sorry! That is not a valid entry");
                userDateOfBirth = Console.ReadLine();

            }

            //output
            return userDateOfBirth;

        }
    }
}