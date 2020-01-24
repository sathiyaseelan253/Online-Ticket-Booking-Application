using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    class UserLoginDetails 
    {
        internal static List<Customers> listOfIds = new List<Customers>();

        static UserLoginDetails()
        {

            listOfIds.Add(new Customers{ Name="Sathiyaseelan",Email="sathyaseelan253@gmail.com",Address="12/4,Middle street,Karur",ContactNumber="8072117799",Password="9566580353"});

            listOfIds.Add(new Customers { Name = "Gokul", Email = "gokul@gmail.com", Address = "14,Gokulapuram,South street,Coimbatore", ContactNumber = "9047670773", Password = "gokul" });
        }
        public static void AskUserForSignin()
        {
            while (true)
            {
                Console.WriteLine("You are new user,signing-in is mandatory for booking");
                Console.WriteLine("Do you want to sign-in\n1=>yes\n2=>no");
                int.TryParse(Console.ReadLine(),out int answer);
                if (answer.Equals((int)Choice.yes))
                {
                    Signin signin = new Signin();
                }
                else if (answer.Equals((int)Choice.no))
                    Console.WriteLine("Okay!!!Thanks,See you next time :)");
                else
                {
                    Console.WriteLine("You entered wrong input");
                    continue;
                }
                break;
            }
        }
    }
}
