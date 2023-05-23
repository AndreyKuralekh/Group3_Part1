using System.Threading;

namespace Group3_Part1
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Print the sum of two numbers: {0}",5 + 5);

            //
            Console.WriteLine("Print the result of dividing two numbers: {0}", 5.0 / 10);

            Console.WriteLine("Print the result of the specified operations:");
            Console.WriteLine("-1 + 4 * 6 = {0}", - 1 + 4 * 6);
            Console.WriteLine("(35 + 5) % 7 = {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", 14 + -4 * 6 / 11);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);

            /*
             swap two numbers 
                   Test Data:
                    Input the First Number : 5
                    Input the Second Number : 6
                    Expected Output:
                    After Swapping :
                    First Number : 6
                    Second Number : 5
            */

            Console.WriteLine();
            Console.WriteLine("Swap two numbers");
            Console.Write("Input first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Swopping....");

            int mediator = firstNumber;
            firstNumber = secondNumber; 
            secondNumber = mediator;

            Console.WriteLine("First  Number : {0}", firstNumber);
            Console.WriteLine("Second Number : {0}", secondNumber);

            /*
             -- print the output of multiplication of three numbers which will be entered by the user 
                   Test Data:
                    Input the first number to multiply: 2
                    Input the second number to multiply: 3
                    Input the third number to multiply: 6
            */

            Console.WriteLine();
            Console.WriteLine("Print the output of multiplication of three numbers which will be entered by the user");

            Console.Write("Input first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third number:");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication = {0}", firstNumber * secondNumber * thirdNumber);
        }
    }
}