using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Hello " + name);
            if(hoursOfSleep > 8)
            {
                Console.WriteLine("Good for you");
            }
            else
            {
                Console.WriteLine("You should get some more sleep.");
            }
            //Console.WriteLine("Hello, " + args[0]);
        }
    }
}
