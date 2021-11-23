﻿using System;
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

        public void Email()
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$";
            Console.WriteLine("Enter your email.:");
            string mail = Console.ReadLine();
            Regex regex = new Regex(email);
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("email is valid");
            }
            else
            {
                Console.WriteLine("emailis not valid");
            }
        }

        public void ValidateEmail()
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$";

            string[] mail = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            Regex regex = new Regex(email);

            foreach (string data in mail)
            {
                if(regex.IsMatch(data))
                {
                    Console.WriteLine(data + " is vaid");
                }
                else
                {
                    Console.WriteLine(data + " is Not vaid");

                }
            }

        }
    }
}
