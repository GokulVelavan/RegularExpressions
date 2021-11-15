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
            obj1.MobileNumber();
            Console.ReadLine();
        }
    }
}
