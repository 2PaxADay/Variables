Console.WriteLine("Hello, World!");

// if-statements (conditional)
// relational and logical operators return boolean value that can only be true or false\

// here we have a short code to allow only numbers from 1 to 10 to pass the input and then calculate the power to that number
Console.WriteLine("Please choose a number between 1 and 10");
int number = int.Parse(Console.ReadLine());

if (number >= 1 && number <= 10)
{
    Console.WriteLine($"{number * number}");
}
else
{
    Console.WriteLine("Wrong input");
}

// if statements can be nested inside other if statements
// More complex example of an ATM machine

const string pinCode = "1234"; 
double balance = 1000;

Console.WriteLine("Please enter your PIN code");
string correctPin = Console.ReadLine();

if (correctPin == pinCode)
{

    Console.WriteLine($"Welcome to your ATM, please choose on of the following options");
    Console.WriteLine("1. Show Balance \n2. Withdraw \n3. Deposit");
    string option = Console.ReadLine();

    if (option == "1")
    {
        Console.WriteLine($"Your balance is {balance}");
    }
    if (option == "2")
    {
        Console.WriteLine("How much do you want to withdraw?");
        int withdrawAmount = int.Parse(Console.ReadLine());

        if (withdrawAmount <= balance)
        {
            balance -= withdrawAmount;
            Console.WriteLine($"You've withdrawn {withdrawAmount}");
            Console.WriteLine($"Your current balance is {balance}");
            Console.WriteLine("Thank you for using our ATM Machine!");
        }
        else
        {
            Console.WriteLine($"Sorry, you tried to withdraw {withdrawAmount} but your balance is {balance}");
            Console.WriteLine("Please press any key to try again.");
            Console.ReadLine();
        }
    }
    if (option == "3")
    {
        Console.WriteLine("How much do you wish to deposit?");
        int addAmount = int.Parse(Console.ReadLine());
        balance += addAmount;
        Console.WriteLine($"Thank you for depositing {addAmount}, your new balance is {balance}");
    }


}
else
{
    Console.WriteLine("Wrong PIN code");
}


// Switch case ( pattern matching )

//1. Constant pattern matching

Console.WriteLine("Please enter a character: "); // here we have a simple way to determine if a character is a vowel or consonant using switch
char character = char.Parse(Console.ReadLine());

switch (character)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Consonant");
        break;
}

/*
can also be like:
switch (character)
{
case 'a':
 Console.WriteLine("Vowel");
break;
case 'e':
 Console.WriteLine("Vowel");

And so on
*/

//2. Relational pattern matching using > >= < <=

int numberr = 500;

switch (numberr)
{
    case > 500:
        Console.WriteLine("Number is greater than 500");
        break;
    case < 500:
        Console.WriteLine("Number is lesser than 500");
        break;
    default:
        Console.WriteLine("Number is equal to 500");
        break;
}

//3, Logical pattern matching using and or not (&& || !)

int numberrr = 500;

switch (numberrr)
{
    case >= 1 and <= 100:
        Console.WriteLine("Number is between 1 and 100");
        break;
    case > 100 and <= 200 and not 150:
        Console.WriteLine("Number is between 100 and 200, excluding 150");
        break;
    case > 500 or < 0:
        Console.WriteLine("Above 500 and negative");
        break;
    default:
        Console.WriteLine("Wrong input easter egg you got 150");
        break;
}

// Ternary operator ?:

// result = (condition)? true_action : false_action;

// simple age verification using Ternary operator
int age = 20;
string isAdult = age >= 18 ? "adult" : "Minor";
Console.WriteLine(isAdult);


// TryParse() Method



Console.WriteLine("Enter integer values");  // will fail because what if user inputs a non integer value?
int val = int.Parse(Console.ReadLine());

Console.WriteLine("You entered: " + val);


Console.WriteLine("Enter integer value");

bool ok = int.TryParse(Console.ReadLine(),out int integerValue);// input source and output source

if (ok)
{
    Console.WriteLine(ok);
}



if(int.TryParse(Console.ReadLine(),out int integerValue)) // even better and more compact way to code the above search for the boolean value of the users input, in this case integer
{
    Console.WriteLine(integerValue);
}
else
{
    Console.WriteLine("Wrong Input, please use integer");
}


// Random generation and Random Class

Random rnd = new Random(); 

// Random always outsputs integer numbers

Console.WriteLine(rnd.Next(1, 11));// this will output a random number from 1 to 10, bc the higher number is always excluded in this case 11
Console.WriteLine(rnd.Next(100)); // this will output a random number from 0-99

//Console.WriteLine(rnd.NextDouble()); // will output a double number between 0 and 1. EX: 0.95142

// Date Time Struct

