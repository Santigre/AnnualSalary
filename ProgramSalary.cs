using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1 hourly rate?");
            string oneHourlyRate = Console.ReadLine();
            Console.WriteLine("Person 1 hours worked per week?");
            string oneHourWorked = Console.ReadLine();

            Console.WriteLine("Person 2 hourly rate?");
            string twoHourlyRate = Console.ReadLine();
            Console.WriteLine("Person 2 hours worked per week?");
            string twoHourWorked = Console.ReadLine();

            int oneHR = Convert.ToInt32(oneHourlyRate);
            int oneHW = Convert.ToInt32(oneHourWorked);

            int oneWeeklyPay = oneHR * oneHW;
            int oneAnnual = (oneWeeklyPay * 4) * 12;
            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine("$" + oneWeeklyPay);
            //Console.WriteLine("Annual salary of Person 1:");
            //Console.WriteLine("$" + oneAnnual);

            int twoHR = Convert.ToInt32(twoHourlyRate);
            int twoHW = Convert.ToInt32(twoHourWorked);

            int twoWeeklyPay = twoHR * twoHW;
            int twoAnnual = (twoWeeklyPay * 4) * 12;
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine("$" + twoWeeklyPay);
            //Console.WriteLine("Annual salary of Person 2:");
            //Console.WriteLine("$" + twoAnnual);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare = oneAnnual > twoAnnual;
            Console.WriteLine(compare);

            Console.ReadLine();

        }
    }
}
