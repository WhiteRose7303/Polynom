using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_to_the_power_of_B
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("input a");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input b");
            int input2 = int.Parse(Console.ReadLine());
            int number = 0;
            for (int i = 0; i < input2; i++)
            {
                number = input1 * input1;
            }
            Console.WriteLine(number);
        }
    }
}