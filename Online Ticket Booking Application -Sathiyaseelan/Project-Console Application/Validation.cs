using System;
using System.Text.RegularExpressions;

namespace Project_Console_Application
{
    class Validation
    {
        public bool ValidateEmail(string email)
        {
           
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(email))
                return true;
            
            else
                Console.WriteLine("Email is not in Correct format");
                return false;

           
           
        }
        public bool ValidateContactNumber(string contactNumber)
        {

            Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (regex.IsMatch(contactNumber))
                return true;

            else
                Console.WriteLine("Should contain 10 digits numbers");
            return false;

           
        }
        public bool PasswordValidation(string contactNumber)
        {

            Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?!.*(.)\1\1)[a-zA-Z0-9@]{6,12}$");
            if (regex.IsMatch(contactNumber))
            {
                while (true)
                {
                    Console.WriteLine("Reenter the password");
                    string rePass = ReadPassword();
                    if (contactNumber.Equals(rePass))
                    {
                        Console.WriteLine("Both are Matched");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Password mismatch");
                        continue;
                    }

                }
                return true;
            }
               

            else
                Console.WriteLine("Not in Correct format(Length >=6) should contain A-Z and any digits  0-9 and a-z ");
            return false;



        }
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }


    }
}
