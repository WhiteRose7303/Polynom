using System;

namespace Polynom_Master
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] cofarr = new int[10];

            int NumberOfCoaff = ReadCoaff(cofarr);
        }

        public static int ReadCoaff(int[] cofarr)
        {
            string str;
            for (int i = 0; i < cofarr.Length; i++)
            {
                Console.Write("enter the coff of X by the power of " + i + " or quit to quit.. ");
                str = Console.ReadLine();
                if (str == "quit")
                {
                    return (i);
                }
                else
                {
                    cofarr[i] = int.Parse(str);
                }
            }
            return (cofarr.Length);
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