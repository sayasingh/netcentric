using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 8;

            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("x=" + x + ",y=" + y);
        }
    }
}
