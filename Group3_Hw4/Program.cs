using System.ComponentModel;

namespace Group3_Hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int width = 140;
            const int height = 40;
            Console.SetWindowSize(width, height);

            int[] array = {1,12,35,6,8,9,12,19};

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write a C# methods to find the largest and lowest value from three integer values.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            int firstInt, secondInt, therdInt;

            Console.Write("Input first integer :");
            firstInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer :");
            secondInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input therd integer :");
            therdInt = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Largest value from three integer values is: {GetLagestInt(firstInt, secondInt, therdInt)}");
            Console.WriteLine($"Lowest value from three integer values is : {GetLowestInt(firstInt, secondInt, therdInt)}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            Console.Write("Input first integer :");
            firstInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer :");
            secondInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The nearest value of 20 of two given integers and return 0 if two numbers are same : {GetNearest20Int(firstInt, secondInt)}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write a C# method to compute the sum of all the elements of an array of integers.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine($"The sum of all the elements of an array of integers is : {GetArraySummaryInt(array)}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write a C# method to get the larger value from array.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine($"The sum of all the elements of an array of integers is : {GetArrayMaxInt(array)}");
        }

        //Write a C# method to find the largest value from three integer values.
        public static int GetLagestInt(int firstInt, int SecondInt, int therdInt)
        {
            int result = firstInt;

            if (result < SecondInt)
                result = SecondInt;

            if (result < therdInt)
                result = therdInt;

            return result;
        }
        //Write a C# method to find the lowest value from three integer values.
        public static int GetLowestInt(int firstInt, int SecondInt, int therdInt)
        {
            int result = firstInt;

            if (result > SecondInt)
                result = SecondInt;

            if (result > therdInt)
                result = therdInt;

            return result;
        }
        //Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
        public static int GetNearest20Int(int firstInt, int SecondInt)
        {
            int result = 0;

            if (!(firstInt == SecondInt))
            {
                result = firstInt;

                if (Math.Abs(20 - firstInt) > Math.Abs(20 - SecondInt))
                    result = SecondInt;
            }
            
            return result;
        }
        //Write a C# method to compute the sum of all the elements of an array of integers
        public static int GetArraySummaryInt(int[] array)
        {
            int result = 0;
            
            foreach(int item in array) 
            { 
                result = result + item;
            }

            return result;
        }
        //Write a C# method to get the larger value from array
        public static int GetArrayMaxInt(int[] array)
        {
            int result = array[1];

            foreach (int item in array)
            {
                if (result < item)
                    result = item;
            }

            return result;
        }
    }
}