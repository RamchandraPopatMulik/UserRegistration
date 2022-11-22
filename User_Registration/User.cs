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
        public void UserInput()
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
                UserInput();
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
        public void CheckValidMobile()
        {
            Console.Write("Enter Mobile Number with Country Code and Space between them : ");
            string mobileNumber = Console.ReadLine();
            Regex number = new Regex(@"^*[+][1-9]{1,3}\s[1-9]{1}[0-9]{9}$");
            bool matches = number.IsMatch(mobileNumber);
            if (matches == true)
            {
                pass = true;
                Console.WriteLine($"{mobileNumber} is Valid Mobile Number");
                return;
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Mobile Number {mobileNumber}");
                CheckValidMobile();
            }
        }
        public void ValidatePassword()
        {
            Console.WriteLine("Please Enter Password  : ");
            string password = Console.ReadLine();
            Regex pass = new Regex("^[A-za-z0-9]{8,}");
            bool matches = pass.IsMatch(password);
            if (matches == true)
            {
                Console.WriteLine($" {password} is Valid Password ");
            }
            else
            {
                Console.WriteLine($" Please Enter Valid Password {password} ");
                ValidatePassword();
            }
        }
    }
}
