using System;

namespace Polynom_Master
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        //This is the power of of the number
        public static int NuPow(int input1, int input2)
        {
            int number = 0;
            for (int i = 0; i < input2; i++)
            {
                number = input1 * input1;
            }
            return number;
        }
    }
}