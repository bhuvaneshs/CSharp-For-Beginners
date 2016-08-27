using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSamples
{
    class SingleInheritance
    {
        public static void Main()
        {
            User user = new User();
            Console.WriteLine("Enter the Firstname :");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter the Lastname :");
            string lastname = Console.ReadLine();

            Console.WriteLine("User fullname is :" +firstname+" "+lastname);
            Console.ReadLine();
        }
    }

    public class Users  // Class for creating logic to get and set properties.
    {
        protected string firstname;
        protected string lastname;

        public void setFirstname(string fname)
        {
            firstname = fname;
        }
        public void setLastname(string lname)
        {
            lastname = lname;
        }
    }

    public class User : Users   //Implemeting single inheritance
    {
        public string getFullName()
        {
            return firstname +" "+lastname;
        }
    }
}
