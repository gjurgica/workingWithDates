using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(new DateTime(2019, 04, 10));
            Console.WriteLine(new DateTime(2018, 01, 07));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.WriteLine(DateTime.Now.Year);
            Console.ReadLine();

        }
       
    }
}
