//1. Write a C# program to check whether a string is a palindrome.
using System;

internal class StringPalindrome
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Basic validation
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        // Normalize string (ignore case and spaces)
        string cleaned = input.Replace(" ", "").ToLower();

        int left = 0;
        int right = cleaned.Length - 1;
        bool isPalindrome = true;

        // Check from both ends
        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }

        Console.WriteLine(isPalindrome
            ? "String is Palindrome"
            : "String is Not a Palindrome");
    }
}
