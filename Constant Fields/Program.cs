using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

const double PI = 3.14;

const double dayDiscount = 0.5; // in %


// Operators

/*Modulus ( % ) is a way to get information on a remainder of an integer number, for instance 7 / 2 is 3 and the remaining number would be 1
 modulus would only show number 1 */


double res = 10 / 3.0;  // Has to be number with .0 or adding another double ex: double res = 10 /(double)3

Console.WriteLine(res);

int quotation = 7 / 2;
int remainder = 7 % 2;

Console.WriteLine($"7/2 = {quotation} remaining number is = {remainder}");

int totalMinutes = 150;
int hours = 150 / 60;
int minutes = 150 % 60;

Console.WriteLine($"{totalMinutes}mins Current time is {hours}H and {minutes}Min");

int totalMonths = 28;
int year = 28 / 12;
int months = 28 % 12;

Console.WriteLine($"{totalMonths} months is {year} and {months} months");


// C# Math Class

double number = 49;
double root = Math.Sqrt(number);  // Math.Sqrt is Square root of a number
Console.WriteLine(root);

double x = 5;
double p = 2;
double xRaised = Math.Pow(x, p); //Math.Pow is power of a number in this case 25
Console.WriteLine(xRaised);

// Standard method ReadLine()

Console.Write($"Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Welcome {name}");

Console.WriteLine("Please press ENTER to continue");
Console.ReadLine();


// Type conversion
/* To convert "number" to real number ( string will show number but it is not usable in math, just as a text ) we use int.Parse()
 it converts a number from a string to a int number.
Equally we can use double.Parse() */


Console.Write($"Enter a number ");
string numberString = Console.ReadLine();
int numberReal = int.Parse(numberString);
Console.WriteLine(numberReal);

Console.Write($"Please enter a second number ");
string secondNumberString = Console.ReadLine();
int secondReal = int.Parse(secondNumberString);
Console.WriteLine(secondReal);

Console.WriteLine("Please press ENTER to add ");
Console.ReadLine();

Console.WriteLine($"{numberReal} + {secondReal}");
Console.WriteLine((numberReal) + (secondReal));

// My code above and Gemini's code below

Console.Write($"Calculator 2. Enter a number ");
int numberReal1 = int.Parse(Console.ReadLine());

Console.Write($"Please enter a second number ");
int secondReal1 = int.Parse(Console.ReadLine());

Console.WriteLine($"{numberReal1} + {secondReal1} = {numberReal1 + secondReal1}");

Console.Write($"Calculator 3. Enter a number ");
double numberReal2 = double.Parse(Console.ReadLine());

Console.Write($"Please enter a second number ");
double secondReal2 = double.Parse(Console.ReadLine());

Console.WriteLine($"{numberReal2} + {secondReal2} = {numberReal2 + secondReal2}");



// Console.Write($"Please choose operation ");


// Arithemtic Assignment Operators

// Addition assignment (+=)
// Here we try to make a score for the game, which updates by level completion
 int score = 0; // start of the game
 score = score + 10; // completing lvl 1
 score = score + 10; // completing lvl 2
 score += 10; // short form of the above - statements are exactly the same

// substraction assignment (-=)
 score = score - 10;
 score -= 10;
// can be done with all Arithmetic assignment operators aka +-*/%



// Increment & Decrement operators
/*

int goblinHealth = 10;
while (goblinHealth > 0 && goblinHealth <15)
{
   Console.WriteLine($"You're approached by a shady Gobli,his health is {goblinHealth}. What do you wish to do?");
Console.WriteLine("⚔️ 1 - Attack him for 1 damage?");
Console.WriteLine("♥️ 2 - Heal him for 1 Health?");
string choice = Console.ReadLine();

if (choice == "1")
{
   goblinHealth--;
   Console.WriteLine($"You've damaged the Goblin! His health is now {goblinHealth}");
}
else if (choice == "2")
{
   goblinHealth++;
   Console.WriteLine($"You've healed the Goblin! His health is now {goblinHealth}");
}
else
{
   Console.WriteLine("You chose to stare at him, the Goblin stares back at you confused 😵‍💫"); // In this case we get this result if we input anything other than 1 or 2 because we left the readline open while giving the choice.
}

}

if (goblinHealth <= 0)
{
   Console.WriteLine("☠️ You've slain the Goblin! Your reward is 100 coins");
}
else if (goblinHealth >= 14)
{
   Console.WriteLine("🧟‍♂️ You've healed the Goblin to his full health! He is now your companion!");
}
*/

// Relational operators
/* Equal to ==
Not equal to !=
Less than <
Greater than >
Less than OR equal to <=
Greater than OR equal to >=
*/

// return boolean results

/*
int number1 = 10;
int number2 = 10;

bool result = number1 == number2; // to see if number1 and number2 are equal or not
Console.WriteLine(result);

string str = "hello";
bool resultStr = str == "hello";
Console.WriteLine(resultStr);
*/

int number1 = 10;
int number2 = 20;

bool result = number1 != number2; // True because number1 is NOT equal to number2

Console.WriteLine(result);

// Logical operators
/*
 * Logical AND &&
 * Logical OR ||
 * Logical NOT !
 */

// AND - Returns as True only if both operands are True, otherwise it returns False

bool resultEND = true && true; // Only condition when it returns the logic as true
bool resultENDF = false && false; // FALSE

Console.WriteLine(resultEND);
Console.WriteLine(resultENDF);


Console.WriteLine("Please enter a number from 1 to 10");
int number3 = int.Parse(Console.ReadLine()); // here we try to make a logic to see if a number is between 1 and 10
bool numberCheck = number3 >= 1 && number3 <= 10;
Console.WriteLine($"In range? {numberCheck}");

const string user = "Marko";
const string password = "12345";

Console.WriteLine("Please enter your username");
string userInput = Console.ReadLine();
Console.WriteLine("Please enter your password");
string passwordInput = Console.ReadLine();

bool login = user == userInput && password == passwordInput;

Console.WriteLine(login);


// more complex example

Console.WriteLine("Please insert number1");
double complexNumber1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please insert number2");
double complexNumber2 = double.Parse(Console.ReadLine());
Console.WriteLine("Please insert + or -");
string complexOperation = Console.ReadLine();

bool additionResult = complexNumber1 >= 0 && complexNumber2 >= 0 && complexOperation == "+";
bool deductionResult = complexNumber1 >= 0 && complexNumber2 >= 0 && complexOperation == "-";

if (additionResult)
{
    double complexAdditionResult = complexNumber1 + complexNumber2;
    Console.WriteLine($"{complexAdditionResult}");
}
else if (deductionResult)
{
    double complexDeductionResult = complexNumber1 - complexNumber2;
    Console.WriteLine($"{complexDeductionResult}");
}

// Logical OR ||
// Example of customer buying something and getting a discount

int buyMilk = 6;
int buyCookie = 2;
bool haveLoyaltyCard = true;

bool getDiscount = buyMilk > 5 || buyCookie > 5; || haveLoyaltyCard;
//                 true        ||  false         ||  true
//                          result: true
// even if customer didnt buy enogh milk or cookies, they would still get a discount since they have loyalty card

// Example of a player starting a game again where he can choose to press ENTER or any button but he also has to have 0 lives
// this would be the Logical OR and logical AND implementation

bool pressKey = true;
bool pressButton = false;
int nmbrOfLives = 0;

bool newRound = pressKey || pressButton && nmbrOfLives == 0;
//               true    ||  true      &&   true
//                     true && true = true

// Logical NOT - like a switch for one operand

bool exResult = !false; // this would make it true

