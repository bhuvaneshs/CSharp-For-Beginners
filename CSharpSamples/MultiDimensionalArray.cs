using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSamples
{
    public class MultiDimensionalArray
    {
        public static void Main()
        {
            int[,] i = new int[2, 4] { { 1, 2,3,4 }, { 1, 2,3,4 } };
            for (int a = 0; a <2; a++)
            {
                for (int b = 0; b <5; b++)
                {
                    Console.WriteLine(i[a,b]);
                    
                }
            }
            Console.ReadLine();
        }
        
    }
}
