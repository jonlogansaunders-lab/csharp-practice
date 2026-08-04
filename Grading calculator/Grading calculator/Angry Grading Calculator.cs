namespace Grading_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables for calculator
            int grade = 100;

            //declare if statements for grading
            if (grade >= 90)
            {
                Console.WriteLine("You passed with an A, smarty pants!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("You passed with a B, you could do better!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("You barely passed with a C, study ASAP!");
            }
            else
            {
                Console.WriteLine("You failed, there's no D's in this class");
            }

        }
    }
}
