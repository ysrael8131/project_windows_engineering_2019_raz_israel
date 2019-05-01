using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime1 = new DateTime(2019, 4, 7,9,1,10);
            DateTime dateTime2 = dateTime1.AddMinutes(10);
            Console.WriteLine(dateTime1);
            
        }
    }
}
