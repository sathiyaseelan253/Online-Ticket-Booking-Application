using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    
    class Signin 
    {
        FrontPage frontPage = new FrontPage();
        Validation validation = new Validation();
        string email;
        string contactNumber;

        string password;
        public Signin()
        {

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Email");
           
            do {

                email = Console.ReadLine();
            } while (!validation.ValidateEmail(email));



            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter your Contact");
            do
            {

                contactNumber = Console.ReadLine();
            } while (!validation.ValidateContactNumber(contactNumber));

           
            Console.WriteLine("Enter your Password");
            do
            {
                password = Validation.ReadPassword();
            } while (!validation.PasswordValidation(password));

            
            UserLoginDetails.listOfIds.Add(new Customers (name, email, address,contactNumber, password ));
            Console.WriteLine("Account Successfully created :) ");
            frontPage.ShowFunctionalities();
        }
      
    }
}
