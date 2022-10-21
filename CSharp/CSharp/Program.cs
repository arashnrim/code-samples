///// String interpolation
const string word = "World";
Console.WriteLine("Hello {0}!", word); // Using positional arguments
Console.WriteLine($"Hello {word}!"); // Using string interpolation; note the $!
Console.WriteLine($"Hello {word.ToUpper()}!"); // Using string interpolation and expression

///// String formatting
// $"{value,[alignment]:[format][precision]"
// See https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
Console.WriteLine($"Hello {word,10}!"); // Right-align
Console.WriteLine($"Hello {word,-10}!"); // Left-align

const double myGPA = 5.0 / 3.0;
Console.WriteLine($"My GPA is {myGPA:F2}"); // Format to 2 decimal places

//// String manipulation
Console.WriteLine(word.Length); // Length of string
Console.WriteLine(word[0]); // First character of string
Console.WriteLine(word[word.Length - 1]); // Last character of string

///// Reading input
Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}!");

// Input validation
// [!] May change in the future!
int age;
do
{
    Console.Write("Enter your age: ");
    try
    {
        age = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter an integer.");
        age = -1;
    }
} while (age < 0);

float height;
do
{
    Console.Write("Enter your height: ");
    try
    {
        height = float.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a float.");
        height = -1;
    }
} while (height < 0);

/****
 * Methods
 * Format: access modifier return type name (parameters)
 * Access modifiers: public, private, protected, internal, protected internal
 * Return type: void (no returns), int, string, etc.
 * Name: PascalCase
 * Parameters: int x, string y, etc.
*/
static void PrintHelloWorld()
{
    Console.WriteLine("Hello World!");
}
PrintHelloWorld();

///// Data types
/*
 * int: 32 - bit signed integer
 * long: 64 - bit signed integer
 * float: 32 - bit floating point number
 * double: 64 - bit floating point number
 * decimal: 128 - bit floating point number
 * bool: true or false
 * char: single character
 * string: sequence of characters
 * object: base class of all types
 */

// Implicit type conversion
int x = 65;
Console.Write((char)x); // Prints 'A', since 65 is the ASCII code for 'A'

// Preventing integer division
int a = 5;
int b = 2;
Console.WriteLine(a / b); // Prints 2, since 5
Console.WriteLine((double)a / b); // Prints 2.5 (at least one operand must be a double/float)

// Pass by value
int x_a = 5;
void AddOneVal(int x)
{
    x_a++;
}
AddOneVal(x_a); // x_a is still 5

// Pass by reference
int[] x_b = { 5 };
void AddOneRef(int[] x)
{
    x[0]++;
}
AddOneRef(x_b); // x_b is now 6
