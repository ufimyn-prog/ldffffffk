using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace fgh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int o=0;
                int result = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out o) && o > 0)
                    {

                        result = result + o;
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                Console.WriteLine(result);






















































            }
        }
    }
}
