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
            Rectangle rect = new Rectangle();
            rect.setWidth(5);
            rect.setHeight(5);

            Console.WriteLine("The area of a rectangle is :" + rect.getArea());
            Console.ReadLine();
        }
    }

    public class Shape
    {
        protected int width;
        protected int height;

        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }

    public class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
}
