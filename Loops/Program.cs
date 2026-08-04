using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

// Loops

//while loop


int loopInfinite = 0;

while (loopInfinite < 10) // loop will run as long as the count is less than 10
{
    Console.WriteLine("Infinite Loop");
    loopInfinite++; // this is our way out of the loop, we keep adding 1 to the int loopInfinite untill it breaks the condition of the loop
}

// user input verification loop example

string password = "";

while (password != "secret")
{
    Console.WriteLine("Provide the password");
    password = Console.ReadLine();

}

Console.WriteLine("Password Accepted!");


// for loop

for ( int forLoop = 0; forLoop < 50; forLoop = forLoop + 3)
{
    Console.WriteLine(forLoop);
}