using System;

DisplayWelcome();

string name = PromptUserName();

int favoriteNumber = PromptUserNumber();

int squaredNumber = SquareNumber(favoriteNumber);

DisplayResult(name, squaredNumber);


// Function 1: Display welcome message
static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the program!");
}


// Function 2: Ask for user's name and return it
static string PromptUserName()
{
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine() ?? "";

    return name;
}


// Function 3: Ask for favorite number and return it
static int PromptUserNumber()
{
    Console.Write("Please enter your favorite number: ");
    string answer = Console.ReadLine() ?? "0";

    int number = int.Parse(answer);

    return number;
}


// Function 4: Square the user's number
static int SquareNumber(int number)
{
    int square = number * number;

    return square;
}


// Function 5: Display the final result
static void DisplayResult(string name, int squaredNumber)
{
    Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
}