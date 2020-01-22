namespace A_to_the_power_of_B
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine(Mypow(2, 1));
        }

        public static int Mypow(int a, int b)
        {
            int num = 1;
            for (int i = 0; i < b; i++)
            {
                num = a * num;
            }
            return num;
        }
    }
}