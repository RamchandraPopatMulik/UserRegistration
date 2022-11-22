using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class User
    {
        bool pass = false;
        public void UserInputName()
        {
            if (pass == false)
            {
                Console.Write("Enter First Name : ");
                string firstName = Console.ReadLine();
                FirstNameAndLastName(firstName);
            }
            if (pass == true)
            {
                Console.Write("Enter Last Name : ");
                string LastName = Console.ReadLine();
                FirstNameAndLastName(LastName);
            }
        }
        public void FirstNameAndLastName(string Name)
        {
            Regex firstLastName = new Regex(@"^([A-z]{1}[a-z]{2,})$");
            bool matches = firstLastName.IsMatch(Name);
            if (matches == true)
            {
                pass = true;
                Console.WriteLine($"{Name} is Valid Name");
                return;
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Name {Name}");
                UserInputName();
            }
        }
        public void Email()
        {
            Console.Write("Enter Email ID : ");
            string email = Console.ReadLine();
            Regex emailID = new Regex(@"^(abc)[a-zA-Z0-9_\+\-\.]*[@](bl)*[.](co)*[.][a-z]{2}$");
            bool matches = emailID.IsMatch(email);
            if (matches == true)
            {
                pass = true;
                Console.WriteLine($"{email} is Valid Email");
                return;
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Email {email}");
                Email();
            }
        }
    }
}
