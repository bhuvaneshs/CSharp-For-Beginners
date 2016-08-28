using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSamples
{
    // One base(parent) class can be inherited to multiple child classes is known as hierarchical inheritance.

    class HierarchicalInheritance
    {
        public static void Main()
        {
            Chennai ch = new Chennai();
            Console.Write("Enter the Event Name :");
            string eventname = Console.ReadLine();
            Console.Write("Enter the Organizer :");
            string organizer = Console.ReadLine();
            ch.setEvent(eventname);
            ch.setOrganizer(organizer);

            ch.GetEvent();
        }
    }

    public class Events   // Parent class
    {
        protected string EventName;
        protected string Organizer;

        public void setEvent(string detail)
        {
            EventName = detail;
        }

        public void setOrganizer(string organizer)
        {
            Organizer = organizer;
        }
    }
    public class Chennai :Events  // child class inherited by parent class
    {
        public void GetEvent()
        {
            Console.WriteLine("Event :" + EventName + " " + Organizer);
            Console.ReadLine();
        }
    }
    public class Delhi : Events  // child class inherited by parent class
    {
        public void GetEvent()
        {
            Console.WriteLine("Event :" + EventName + " " + Organizer);
            Console.ReadLine();
        }
    }
}
