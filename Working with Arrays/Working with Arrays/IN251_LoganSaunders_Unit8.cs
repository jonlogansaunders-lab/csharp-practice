//IN251 Unit 8 Assignment
using System;

namespace IN251_LoganSaunders_Unit8
{
    class Program
    {
        //Main is the entry point for code
        //Function to find the index of the largest number in an array
        static int findMax(int[] numbers, int size)
        {
            int maxIndex = 0;

            for (int i = 1; i < size; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        //Function to determine if each number in the array is even or odd
        static void evenOrOdd(int[] numbers, string[] words, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    words[i] = "even";
                }
                else
                {
                    words[i] = "odd";
                }

            }
        }

        static void Main(string[] args)
        {
            //Declare an array of integers  
            int[] numbers = { 56, 77, 23, 12, 88, 59, 97, 33, 38, 64 };

            // String array
            string[] words = new string[10];

            //Call functions
            int maxIndex = findMax(numbers, numbers.Length);
            evenOrOdd(numbers, words, numbers.Length);

            // Print largest number
            Console.WriteLine("The largest number is: " + 
                numbers[maxIndex] + " located at array index: " + maxIndex + ".");

            Console.WriteLine();
            Console.WriteLine("The numbers were:");
            Console.WriteLine();

            // Print each number with even/odd
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " is " + words[i]);
            }

    }
        }
}


