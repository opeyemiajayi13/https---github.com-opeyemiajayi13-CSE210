using System;
using System.Collections.Generic;

List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

int userNumber = -1;

while (userNumber != 0)
{
    Console.Write("Enter number: ");
    string input = Console.ReadLine() ?? "0";

    userNumber = int.Parse(input);

    if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }
}

if (numbers.Count > 0)
{
    // Calculate the sum
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    // Calculate the average
    double average = (double)sum / numbers.Count;

    // Find the largest number
    int largest = numbers[0];

    foreach (int number in numbers)
    {
        if (number > largest)
        {
            largest = number;
        }
    }

    // Find the smallest positive number
    int smallestPositive = int.MaxValue;

    foreach (int number in numbers)
    {
        if (number > 0 && number < smallestPositive)
        {
            smallestPositive = number;
        }
    }

    // Display results
    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"The largest number is: {largest}");

    if (smallestPositive != int.MaxValue)
    {
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
    }
    else
    {
        Console.WriteLine("There are no positive numbers.");
    }

    // Sort and display the list
    numbers.Sort();

    Console.WriteLine("The sorted list is:");

    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
else
{
    Console.WriteLine("You did not enter any numbers.");
}