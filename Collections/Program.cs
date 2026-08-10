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