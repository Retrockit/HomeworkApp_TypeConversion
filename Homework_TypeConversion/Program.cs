// Homework assignment: Type Conversion
// Date: 4/17/2024
// Description: This program demonstrates the use of type conversion in C#.

//Capture user input. We want to ask the user for their age.
string name;

string age;

int ageConversion = 0;

int AdditionTwentyFive = 0;

int SubtractionTwentyFive = 0;

Console.WriteLine("Hello and welcome to homework assignment number 2");

Thread.Sleep(5000);

Console.WriteLine("In this assignment we will be demonstrating our knowledge of type conversion in C#");

Thread.Sleep(5000);

Console.WriteLine("Let's get started!");

Thread.Sleep(5000);

Console.WriteLine("Welcome to the Shiny the pony's stable!");

Thread.Sleep(5000);

Console.WriteLine("Before you can enter, we need to do calculations and identification!");

Thread.Sleep(5000);

Console.WriteLine("First, can you help us with your name?");

name = Console.ReadLine();

Thread.Sleep(5000);

Console.WriteLine($"Hi {name}!");

Thread.Sleep(5000);

Console.WriteLine("What is your age?");

age = Console.ReadLine();
ageConversion = Convert.ToInt32(age);

Console.WriteLine($"Okay, so you are {age}?");

Thread.Sleep(1000);

Console.WriteLine("Fantastic!");

Thread.Sleep(5000);

Console.WriteLine("Give us a second while we do age calculations");

Thread.Sleep(5000);

AdditionTwentyFive = ageConversion + 25;
SubtractionTwentyFive = ageConversion - 25;

Console.WriteLine(".......");

Thread.Sleep(5000);

Console.WriteLine("Okay so here are your results!");

Thread.Sleep(2000);

Console.WriteLine($"In 25 years from now, you will be {AdditionTwentyFive}");

Thread.Sleep(2000);

Console.WriteLine("and");

Thread.Sleep(2000);

Console.WriteLine($"25 years ago you were {SubtractionTwentyFive}");

Thread.Sleep(5000);

Console.WriteLine($"Welcome to the stable {name} and enjoy your stay!");