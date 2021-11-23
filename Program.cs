using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExoressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to regular expressions");
            Registration obj1 = new Registration();
            obj1.FirstName();
             obj1.LastName();
            obj1.Email();
<<<<<<< HEAD
            obj1.MobileNumber();
            obj1.Password();
=======
            obj1.ValidateEmail();
>>>>>>> UC3-Email
            Console.ReadLine();
        }
    }
}
