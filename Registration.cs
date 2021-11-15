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
                Console.WriteLine("FIRST Name is Valid");
            }
            else
            {
                Console.WriteLine("FIRST name is not valid");
            }
        }
        public void LastName()
        {
            string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Console.WriteLine("Enter your Last Name:");
            string name = Console.ReadLine();
            Regex regex = new Regex(lastName);
            if (regex.IsMatch(name))
            {
                Console.WriteLine("LAST Name is Valid");

            }
            else
            {
                Console.WriteLine("LAST name is not valid");

            }
        }
    }
}
