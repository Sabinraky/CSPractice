using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice
{
    public class Program
    {
        static void Main(string[] args)
        {

            // USE TO CHNAGE CONSOLE VIEW
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            // OUTPUT PRINT STATEMENT
            Console.WriteLine("This is the Basic Structure of the Program");


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter Your Name : ");

            // ASSIGN INPUT VALUE
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name} ! \nWelcome to C# ");
            
        }
    }
}
