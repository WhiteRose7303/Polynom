using System;

namespace Polynom_Master
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool check = true;
            while (check == true)
            {
                int valueofx = 0;
                int final = 0;
                int[] newcofarr = new int[10];
                int[] cofarr = new int[10];
                int[] finalcof = new int[10];
                Console.ForegroundColor = ConsoleColor.Red;
                int NumberOfCoaff = ReadCoaff(cofarr);
                Console.ForegroundColor = ConsoleColor.Green;
                valueofx = ReadInt(valueofx);
                final = CalPoli(cofarr, valueofx, newcofarr, final, finalcof);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(final);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("do you want to contine? Y/N ");
                string str = Console.ReadLine();
                if ((str == "y") || (str == "Y"))
                {
                    check = true;
                    Console.Clear();
                }
                else
                {
                    check = false;
                    Environment.Exit(0);
                }
            }
        }

        //takes the input
        public static int ReadCoaff(int[] cofarr)
        {
            string str;
            for (int i = 0; i < cofarr.Length; i++)
            {
                Console.Write("enter the coff of X by the power of " + i + " or quit to quit.. ");
                str = Console.ReadLine();
                if ((str == "quit") || (str == "q"))
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
        public static int Nupow(int a, int b)
        {
            int num = 1;
            for (int i = 0; i < b; i++)
            {
                num = a * num;
            }
            return num;
        }

        //takes the x
        public static int ReadInt(int x)
        {
            Console.WriteLine("input x value ");
            x = int.Parse(Console.ReadLine());
            return (x);
        }

        public static int CalPoli(int[] cofarr, int x, int[] newcofarr, int final, int[] finalcof)
        {
            for (int i = 0; i < cofarr.Length; i++)
            {
                newcofarr[i] = Nupow(x, i);
            }

            for (int i = 0; i < cofarr.Length; i++)
            {
                finalcof[i] = cofarr[i] * newcofarr[i];
            }

            for (int i = 0; i < cofarr.Length; i++)
            {
                final += finalcof[i];
            }
            return (final);
        }
    }
}