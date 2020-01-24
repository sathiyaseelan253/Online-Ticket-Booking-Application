using System;

namespace Project_Console_Application
{
    public enum Person
    {
        admin=1,
        viewer
    }
    class LoginPage
    {
        ValidateRoles validate = new ValidateRoles();
       
        //Finding who is loging in--Admin or Viewer
        public void IdentifyRole()
        {
            Console.WriteLine("Are you admin or user  1=>admin 2=>user??");
            try
            {
                int.TryParse(Console.ReadLine(),out int choice);
                switch ((Person)choice)
                {
                    case (Person.admin):
                        validate.AdminCheck();
                        break;
                    case (Person.viewer):
                        validate.ViewerCheck();
                        break;
                                               
                }
            }
            catch(OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
