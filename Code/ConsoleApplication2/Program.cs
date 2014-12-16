using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Name Generator");
            Console.WriteLine("Would you like a guy or girl name");
            string input = Console.ReadLine();
            if (input == "guy")
            {
                string[] lines = File.ReadAllLines("guys.txt");
                Random rand = new Random();
                Console.WriteLine("your randomly chosen name is: " + lines[rand.Next(lines.Length)]);
                Console.ReadLine();
            }
            else if (input == "girl")
            {
                string[] lines = File.ReadAllLines("girls.txt");
                Random rand = new Random();
                Console.WriteLine("your randomly chosen name is: " + lines[rand.Next(lines.Length)]);
                Console.ReadLine();
            }
        }
    }
}
