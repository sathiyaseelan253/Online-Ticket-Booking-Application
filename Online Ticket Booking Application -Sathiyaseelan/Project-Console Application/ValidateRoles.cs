using System;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Project_Console_Application
{
    class ValidateRoles
    {
        static string adminLogin = ConfigurationManager.AppSettings["username"].ToString();
        static string adminPassword = ConfigurationManager.AppSettings["password"].ToString();
        public static int userLogedIn = 0;
        public static int adminLogedIn = 0;
        UserLoginDetails userLogin = new UserLoginDetails();
        ChooseFunction choose = new ChooseFunction();
        BookTicket book = new BookTicket();
        MovieModule movieModule = new MovieModule();
      
        public void AdminCheck()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter your admin username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    string password = Console.ReadLine();

                    if (username == adminLogin && password == adminPassword)
                    {
                        Console.WriteLine("Successfully logged in");
                        adminLogedIn++;
                        choose.FunctionToDo();
                    }
                    else
                    {
                        Console.WriteLine("Invalid data's!!!");
                        Console.WriteLine("Re-enter data 1=>yes 2=>no");
                        int.TryParse(Console.ReadLine(),out int choose);
                        if (choose.Equals((int)Choice.yes))
                            continue;
                        else if (choose.Equals((int)Choice.no))
                        {
                            Console.WriteLine("Thanks,See you again :)");
                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid input,please choose valid one");
                            continue;
                        }
                       

                    }
                    break;
                }
                
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
           
        
        public void ViewerCheck()
        {
            //userLogin.AddLoginIds();
            try
            {
                Console.WriteLine("Enter user name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your user password");
                string password = Console.ReadLine();

                //Lambda expression to check username and password
                if (UserLoginDetails.listOfIds.Exists(username => username.Name == name))
                {
                    if(UserLoginDetails.listOfIds.Exists(pass => pass.Password == password))
                    Console.WriteLine("Successfully logged in!!!!!!!!!!!!!");
                    userLogedIn++;
                    
                    movieModule.ViewMovieDetails();
                    
                   
                }

                else
                {
                    Console.WriteLine("Invalid data's!!!");
                    Console.WriteLine("Better sign in");
                    Console.WriteLine("Do you want");
                    UserLoginDetails.AskUserForSignin();

                   
                }
             
                //}
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



       
        }
    }

