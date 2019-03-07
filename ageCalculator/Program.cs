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
            if (birthday.Day == DateTime.Now.Day && birthday.Month == DateTime.Now.Month)
            {
                Console.WriteLine("Happy Birthday");
            }
            else if(birthday.Day - DateTime.Now.Day == 1 && birthday.Month == DateTime.Now.Month){
                Console.WriteLine("Happy birthday, little late");
                                        }
            else if(birthday.Day - DateTime.Now.Day == -1 && birthday.Month == DateTime.Now.Month)
            {
                Console.WriteLine("Just one day left to your birthday");
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
