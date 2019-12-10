using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2SelfAssLab
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int exes = 0; exes < 8; exes++)
            {
                for (int ohs = 0; ohs < 8; ohs++)
                {
                    if ((exes + ohs) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if ((exes + ohs) % 2 == 1)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.WriteLine("Neither X or 0");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
