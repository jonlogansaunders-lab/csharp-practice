namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 83;

            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
