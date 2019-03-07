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
            if (birthday.Day == DateTime.Now.Day)
            {
                Console.WriteLine("Happy Birthday");
            }
            Console.WriteLine(ageCalculator(birthday));
            Console.ReadLine();
        }
        public static int ageCalculator(DateTime date)
        {
             DateTime today = DateTime.Now;
             int year = today.Year;
             return year - date.Year;
        }
    }
}
