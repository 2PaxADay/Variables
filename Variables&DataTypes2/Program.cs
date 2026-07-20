using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

// Concatenation

int year = 2026;
double discount = 1.5;
bool isRightAnswer = false;
char sign = '+';
string message = "Weather is sunny and warm!";

Console.WriteLine("The current year is " + year);
Console.WriteLine("The discount is " + discount);
Console.WriteLine("is this the right answer? " + isRightAnswer);
Console.WriteLine("The addition sing is " + sign);
Console.WriteLine("How is the weather today? " + message);


int number1 = 20;
int number2 = 10;
Console.WriteLine("The sum of" +  number1 + "and" + number2 + "is" + (number1 + number2));

string dontKnow = "10" + 10;

Console.WriteLine(dontKnow);

// Interpolation

Console.WriteLine($"The current year is {year}");

int number3 = 10;
int number4 = 20;
int number5 = 15;
int sum = number3 + number4 + number5;
char plus = '+';
char equals = '=';

Console.WriteLine("The sum of " + number3 + " " + number4 + " " + number5 + " is " + sum); // Concatenation
Console.WriteLine($"The sum of {number3} {number4} {number5} is {sum}"); // Interplotation
Console.WriteLine($"The sum of \n {number3} {plus} {number4} {plus} {number5} \n is {equals} {sum}");
