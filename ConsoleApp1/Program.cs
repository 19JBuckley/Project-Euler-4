namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            int largestnum = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    
                    int product = i * j;
                    int number = product;
                    int reversedNumber = ReverseInteger(number);
                    if (reversedNumber == number)
                    {
                        if (reversedNumber > largestnum)
                        {
                            largestnum = reversedNumber;
                        }

                    }
                }
            }
            Console.WriteLine(largestnum);
        }

        public static int ReverseInteger(int number)
        {
            int reversed = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            return reversed;
        }
    }
}