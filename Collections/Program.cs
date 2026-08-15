using System.ComponentModel;

Console.WriteLine("Hello, World!");

// array

// one dimensional array - also called linear array - using square brackets []

//declaration
// int[] numbers;  // same as: int num;

//initialization
// numbers = new int[10]; // same as: num = 10;

//declaration + initializaiton
// int[] numbers = new int[10]; // practical way of doing above same as // int num = 10;
// what the code above does is reserve 10 spaces in the memory for our variable called numbers
// the variables inside this variable numbers will be assigned 0 as a default value
// all the values are consecutive meaning they are next to each other


//declaration + initialization + value
// int[] numbers = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; // we didnt add the size to the array since the compiler will look into the {} and assign the size to the array in this case 10, since there are 10 values.

int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; // same thing as above only cleaner

//all arrays have a feature called Indexing, which means we can read and write components
// index numbers always start from 0, which means when calling an array the first one is 0.
// in the array above we've added 10 numbers so to call the first one we would need to use 0, to call the last one we would use 9.

Console.WriteLine(numbers[0]);

Console.WriteLine(numbers[9]);
numbers[9] = 95;
Console.WriteLine(numbers[9]);

// Length property will use quite often - returns number of components aka the size of array

Console.WriteLine(numbers.Length); // 10

Console.WriteLine(numbers[numbers.Length - 1]); // Here we are calling the last value in the array by doing 10-1 to show us the value on the 9th place ( last )

// loop on linear array


string[] oruzija = { "sword", "axe", "spear" };

foreach (string x in oruzija)
{
    Console.WriteLine("Player is holding " + x);
}

// here we are making a temporary integer j, its starting value is 0 because the first array is 0, the for loop runs as long as j is smaller than 10 ( because we have 10 arrays in the numbers collection), for everytime it runs it adds a value to j.
//after the value is added it prints it in the console because we are using numbers[j] which actually has a numerical value which is incremented by each pass.
for(int j = 0; j<10; j++)
{
    Console.WriteLine(numbers[j]);
}

// better way to code is to add .Length property so it doesnt crash if we change number of components in an array
for(int j =0; j < numbers.Length; j++)
{
    Console.WriteLine(numbers[j]);
}

// adding together the values of an array

int sum = 0;

for(int j=0; j<numbers.Length; j++)
{
    sum += numbers[j];
}

Console.WriteLine(sum);

//Way of finding specific component in an array combining for and if loops

string[] names = { "Mark", "Jack", "Zack", "Zimmerman", "Dolce" };

bool isFound = false;
string foundName = "";

for(int i =0; i<names.Length; i++)
{
    if (names[i] == "Dolce")
    {
        isFound = true;
        foundName = names[i];
        break;
    }
}

if (isFound)
{
    Console.WriteLine(foundName + " Your name is now saved under the foundName string variable");
}

//Here we make a reserved array space for the user to fill out later, the capacity will be 5

int[] userNumbers = new int[5];

for(int i =0; i<userNumbers.Length; i++)
{
    userNumbers[i] = int.Parse(Console.ReadLine());
}

for(int t = 0; t < userNumbers.Length; t++)
{
    Console.WriteLine(userNumbers[t]);
}

//same thing as above only adding the TryParse method to save the programm from crashing

int[] tryParseUserNumbers = new int[5];

for(int i = 0; i < tryParseUserNumbers.Length; i++)
{
    bool correctInput = false;

    while (!correctInput)
    {
        Console.WriteLine("Please insert a number for position " + i + ": ");
        string userInput = Console.ReadLine();

        correctInput = int.TryParse(userInput, out tryParseUserNumbers[i]);

        if (!correctInput)
        {
            Console.WriteLine("Error, wrong character input");
        }
    }

}

Console.WriteLine("All 5 slots are filled with numbers!");

// This is a method to just print the latest arrays components

for(int i = 0; i<tryParseUserNumbers.Length; i++)
{
    Console.WriteLine(tryParseUserNumbers[i]);
}
