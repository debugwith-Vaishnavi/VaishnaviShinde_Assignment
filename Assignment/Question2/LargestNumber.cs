//2.Write a program to find the largest number in an array.

using System;

internal class LargestNumber
{
    static void Main()
    {

        // Ask user for array size
        Console.Write("Enter number of elements: ");
        string sizeInput = Console.ReadLine();

        // Validate size input
        if (!int.TryParse(sizeInput, out int size) || size <= 0)
        {
            Console.WriteLine("Invalid array size.");
            return;
        }

        int[] numbers = new int[size];

        // Take array elements from user
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            string input = Console.ReadLine();

            // Validate each element
            if (!int.TryParse(input, out numbers[i]))
            {
                Console.WriteLine("Invalid number entered. Please restart.");
                return;
            }
        }

        // Find largest element
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Output result
        Console.WriteLine($"Largest number: {max}");
    }
}