using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calender_view
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weeks = 5;
            int daysInWeek = 7;
            int[][] calendar = new int[weeks][];

            for (int i = 0; i < weeks; i++)
            {
                calendar[i] = new int[daysInWeek];
            }

            int day = 1;
            for (int i = 0; i < weeks; i++)
            {
                for (int j = 0; j < daysInWeek; j++)
                {
                    if (day <= 30)
                    {
                        calendar[i][j] = day++;
                    }
                    else
                    {
                        calendar[i][j] = 0;
                    }
                }
            }

            Console.WriteLine("Sun Mon Tue Wed Thurs Fri Sat");
            for (int i = 0; i < weeks; i++)
            {
                for (int j = 0; j < daysInWeek; j++)
                {
                    if (calendar[i][j] != 0)
                    {
                        Console.Write($"{calendar[i][j],3} ");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
