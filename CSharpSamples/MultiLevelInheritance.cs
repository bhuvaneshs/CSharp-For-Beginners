using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSamples
{
    // one class is derived from another derived class is known as multi-level inheritance
    class MultiLevelInheritance
    {
        public static void Main()
        {
            Tiger t = new Tiger();
           string a = t.GetRhino();
           string b=  t.GetTiger();
           string c= t.GetAnimal();
           Console.WriteLine(a);
           Console.WriteLine(b);
           Console.WriteLine(c);
            Console.ReadLine();
        }
    }

    public class Animal   // Animal class
    {
        public string GetAnimal()
        {
            return "This is common animal";
        }
    }

    public class Rhino:Animal  // Rhino inheriting Animal class
    {
        public string GetRhino()
        {
            GetAnimal();
            return "Rhino is a herbivores";
        }
    }

    public class Tiger : Rhino // Tiger inheriting Rhino class
    {
        public string GetTiger()
        {
            GetAnimal();
            GetRhino();
            return "Tiger is a carnivores";
        }
    }
}
