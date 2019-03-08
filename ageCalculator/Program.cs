using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday in this Format(YYYY-MM-DD):");
            string inputDate = Console.ReadLine();
            DateTime birthday = Convert.ToDateTime(inputDate);
            Console.WriteLine(ageCalculator(birthday));
            Console.ReadLine();
        }
        public static string ageCalculator(DateTime date)
        {
            //get today date
             DateTime today = DateTime.Now;
            //get today year
             int year = today.Year;
            //substracting today year from birth year
             int calculateYear = year - date.Year;
            //get today mounth
            int mounth = today.Month;
            //calculate how much mounth 
            int calculateMounth;
            if (mounth > date.Month)
            {
                calculateMounth = mounth - date.Month;
            }else if (mounth < date.Month)
            {
                calculateYear--;
                calculateMounth = Math.Abs(mounth - date.Month);

            }
            else
            {
                calculateMounth = 0;
            }
            //get today day
            int day = today.Day;
            //calculate hou much days
            int calculateDays;
            if(day > date.Day)
            {
                calculateDays = day - date.Day;
            }else if(day < date.Day)
            {
                calculateMounth--;
                calculateDays = Math.Abs(day - date.Day);
            }
            else
            {
                calculateDays = 0;
            }
            return "You are " + calculateYear + " year " + calculateMounth + " mounth " + calculateDays + " days";
        }
    }
}
