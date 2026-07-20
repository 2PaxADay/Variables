Console.WriteLine("Hello World");
Console.WriteLine("14 Jul 2026 - Prvi Korak");

Console.Write("Jedan");
Console.Write("Dva");


// Escape Sequences (\)

// 1. Double quotes - \"\"
Console.WriteLine("We are learning C#");
Console.WriteLine("Ako hocemo da nesto bude pod \"navodnicima\", moramo da stavimo escape pre prvih navodnika i pre sledecih");


// 2. Tab - \t
Console.WriteLine("Column1\tColumn2\tColumn3");
Console.WriteLine("Column1\t\tColumn2\t\tColumn3");
Console.WriteLine("Column1\t\t\tColumn2\t\t\tColumn3");

// 3. Newline - \n
Console.WriteLine("Name:Mark\nAge:25\nProfession:Programmer");

// 4. Backslash - \
Console.WriteLine("C:\\User\\Admin\\text.txt");




// Comments

// This is a single line comment
int logiAttempt = 0;
const string username = "username";
const string password = "password";

/*
This is a multiline comment 
everything in here is a comment
*/

static void CalculatesRevenue(double gross)
{

}

/// <summary> This is the XML documentation comment </summary>
/// <param name="num1"> First Number to Add </param>
/// <param name="num2"> Second Number to Add </param>
/// <return> The Sum of two numbers </return>

static double Add(double num1, double num2) { return num1 + num2; }

// Errors

// 1. Compile time Errors are errors in syntaxes aka code

// 2. Runtime Error

// int number = int.Parse(Console.ReadLine());

int[] numbers = { 1, 2, 3, 4, 5 };

int index = int.Parse(Console.ReadLine());
Console.WriteLine(numbers[index]);

// 3. Logical Error - This is fixed by debbuging ( looking through the steps of the code because the code works just not in the intended way)

int eq = 10 + (40 - 34) * (5 + 9) / 3;

// Productivity tips

// 1. shortcut for Console.WriteLine is cw
Console.WriteLine();

// 2. Tab completion - press tab twice when offerred the correct code

// 3. Light bult ( suggestion for advanced code )

// 4. Go to definition - Right click on the definition then choose "go to definition" to find its source aka what it is assigned, what it is
// 5. Indentation - CTRL + K releaser then D, it will indent all the code
// 6. Get help - Hover over a method and press F1 to open the browser to see what it does if unsure