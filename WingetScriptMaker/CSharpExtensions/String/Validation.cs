using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace CSharpExtensions.String
{
    public static class Validation
    {
        public static string LastErrorMessage { get; private set; }

        public static bool EMailIsValid(string emailAddress)
        {
            try
            {
                LastErrorMessage = "";
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool PasswordIsValid(string password, string userName)
        {
            LastErrorMessage = "";
            if (password.Contains(userName))
                return false;

            string pattern = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            /*
                At least one lower case letter,
                At least one upper case letter,
                At least one special character,
                At least one number
                At least 8 characters length
             */
            return Regex.Match(password, pattern).Success;
        }

        public static bool DiscordIsValid(string discord)
        {
            LastErrorMessage = "";
            if (discord == "")
                return true; // if discord is not given by the user at registration.

            string pattern = @"^(.+?)#\d{4}$";
            //<Any char, except line break>#<4 digit char>
            return Regex.Match(discord, pattern).Success;
        }

        public static bool DateIsValid(string date)
        {
            LastErrorMessage = "";
            if (date == "")
                return true; // if date is not given by the user at registration.

            string pattern = @"^[12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$";
            //1978-12-20 format
            return Regex.Match(date, pattern).Success;
        }
    }
}
