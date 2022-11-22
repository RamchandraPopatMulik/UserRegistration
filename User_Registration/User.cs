using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class User
    {
        public void FirstName(string name)
        {
            Regex firstName = new Regex(@"^([A-z]{1}[a-z]{2,})$");
            bool matches = firstName.IsMatch(name);

            if(matches == true)
            {
                Console.WriteLine($"{name} is Valid");
            }
            else
            {
                Console.WriteLine($"{name} is InValid");
            }
        }
    }
}
