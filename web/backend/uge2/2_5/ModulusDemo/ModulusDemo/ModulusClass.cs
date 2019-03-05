using System;
using System.Collections.Generic;
using System.Text;

namespace ModulusDemo
{
    static class ModulusClass
    {
        public static void DemoModulus()
        {
            for (int i = 1; i<= 20; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine("The value:" + i + " is an even number");
                }
                else
                {
                    Console.WriteLine("The value:" + i + " is an odd number");
                }
            }
        }
    }
}
