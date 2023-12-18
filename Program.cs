using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Time_validation_Script
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
            //otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

            Console.WriteLine("please enter time in HH:MM format");
            string input = Console.ReadLine();

            DateTime theTime;

            if (DateTime.TryParse(input, out theTime))
            {
                Console.WriteLine("ok");
            } else Console.WriteLine("invalid time");


        }
    }
}
