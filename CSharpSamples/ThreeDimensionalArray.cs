using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSamples
{
    class ThreeDimensionalArray
    {
        public static void Main()
        {
            int[,,] i = new int[2, 2, 3] {{ {1,2,3},{1,2,3} },
                                            {{1,2,3},{1,2,3}}
                                          };
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.WriteLine(i[a, b,c]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
