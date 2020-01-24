using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    public enum Todo
    {
        viewmovies=1,
        login,
        signIn
    }
    class FrontPage
    {
        MovieModule module = new MovieModule();
        LoginPage login = new LoginPage();
      
        public void ShowFunctionalities()
        {
            Console.WriteLine("**********************Welcome to Online Ticket Booking System**********************");
            Console.WriteLine("Enter any one\n\n1=>Viewmovies\n2=>Login\n3=>Sign-In");
            try
            {
                int.TryParse(Console.ReadLine(),out int input);

                switch ((Todo)(input))
                {
                    case Todo.viewmovies:
                        
                        module.ViewMovieDetails();
                        break;
                    case Todo.login:
                        login.IdentifyRole();
                        break;
                    case Todo.signIn:
                        Signin sign = new Signin();
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
