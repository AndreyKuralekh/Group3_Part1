using System.ComponentModel;

namespace Group3_Hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int width     = 140;
            const int height    = 40;
            Console.SetWindowSize(width, height);

            #region Task #1
            /*
                Write a C# program to check two given integers and return true if one is negative and one is positive.
                Sample Output:
                Input first integer: -5
                Input second integer: 25
                Check if one is negative and one is positive:             True
            */
            var result = true;

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write a C# program to check two given integers and return true if one is negative and one is positive.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            Console.Write("Input first integer :");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            if (!((firstNumber > 0 && secondNumber < 0) || (firstNumber < 0 && secondNumber > 0)))
            {
                result = false;
            }
            Console.WriteLine($"Check if one is negative and one is positive:             {result}");
            #endregion

            #region Task #2
            /*
            Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            */
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            Console.Write("Input first integer :");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            result = true;

            if (!((firstNumber == 20 || firstNumber + secondNumber == 20) || (secondNumber == 20 || firstNumber + secondNumber == 20)))
            {
                result = false;
            }
            Console.WriteLine($"Check if one of the integer is 20 or if their sum is 20:  {result}");
            #endregion
            
            #region Task #3
            /*
            Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            */
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Prss any key to continue....");
            Console.ReadKey();

            for ( int i = 0; i < 100; i=i+2 ) 
            {
                Console.WriteLine($"The list of odd numbers from 1 to 99: {i}");
            }

            #endregion

            #region Task #4
            /*
            - Write a C# program to compute the sum of the first 500 prime numbers.
                 Sample Output:
                 Sum of the first 500 prime numbers:              824693
            */
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("sum of the first 500 prime numbers.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Sum of the first 500 prime numbers: {SumOfPrimes(500)}");

            #endregion

            #region Task #5
            /*
            - Write a C# program and compute the sum of the digits of an integer.
             Sample Output:
             Input a number(integer): 12 (string.Length)
             Sum of the digits of the said integer: 3
            */
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write a C# program and compute the sum of the digits of an integer.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            Console.Write("Input integer:");
            string ImportNumber = Console.ReadLine();

            int len = ImportNumber.Length;
            int summ = 0;
            for (int i2 = 0; i2 < len; i2++)
            {
                summ = summ + Int32.Parse(ImportNumber.Substring(i2, 1));
            }
            Console.WriteLine($"Sum of the digits of an integer: {summ}");
            #endregion
        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static int SumOfPrimes(int n)
        {
            int sum = 0;
            int count = 0;
            int i = 2;
            while (count < n)
            {
                if (IsPrime(i))
                {
                    sum += i;
                    count++;
                }
                i++;
            }
            return sum;
        }
    }
}