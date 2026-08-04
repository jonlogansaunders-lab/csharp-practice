namespace Even_Or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            int remainder = number % 2;

            if (remainder == 0)
            {
                Console.WriteLine(number + " is even");
            }
            else

            {
                Console.WriteLine(number + " is odd");
            }
            
        }
    }
}
