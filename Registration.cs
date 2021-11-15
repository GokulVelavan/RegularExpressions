using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegularExoressions
{
    class Registration
    {
        public void FirstName()
        {
            string firstName = "^[A-Z]{1}[a-zA-Z]{2,}";
            Console.WriteLine("Enter your First Name: ");
            string name = Console.ReadLine();
            Regex regex = new Regex(firstName);
            if(regex.IsMatch(name))
            {
                Console.WriteLine("Name is Valid");
            }
            else
            {
                Console.WriteLine("name is not valid");
            }
        }
    }
}
