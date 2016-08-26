using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSamples
{
    public class SingleDimensionArray
    {
        public static void Main()
        {
            int[] i = new int[2] { 1, 2 };
            for (int a = 0; a < i.Length; a++)
            {
                Console.WriteLine(i[a]);
                Console.ReadLine();
            }
        }
    }
}
