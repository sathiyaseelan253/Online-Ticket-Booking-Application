using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
   
    class Customers
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string ContactNumber { get; set; }

        public string Password { get; set; }

        public Customers(string name, string email, string address, string contactNumber, string password)
        {
            Name = name;
            Email = email;
            Address = address;
            ContactNumber = contactNumber;
            Password = password;
        }
        public Customers()
        {

        }
    }
}
