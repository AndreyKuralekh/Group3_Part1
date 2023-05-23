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
            Console.WriteLine("Enter value:");
            string? test = Console.ReadLine();
            double testDouble;

            if (double.TryParse(test, out testDouble))
            {
                Console.WriteLine("The value is: {0}", testDouble);
            }
            else 
            {
                Console.WriteLine("Couldn`t convert");
            }
        }
    }
}