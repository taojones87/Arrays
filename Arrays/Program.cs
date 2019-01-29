using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction message, no user input necessary.
            Console.WriteLine("Welcome to the array program. The program will now list each element value in the array.");
            Console.WriteLine("");

            // Create an array with 25 elements.
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            // Display each element in the array.
            foreach (int i in array1)
            {
                Console.WriteLine("Element Value = " + i);
            }

            // Closing message and instructions.
                Console.WriteLine("");
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey(true);            
        }
    }
}
