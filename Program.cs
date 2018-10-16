using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = new int[5] { 0, 1, 2, 3, 4, };

            string[] weekdays = new string[7] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };


            for (int i = 0; i <number .Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine(weekdays[i]);
            }

            foreach (var name in weekdays)
            {
                Console.WriteLine(name);
            }
        }
    }
}
