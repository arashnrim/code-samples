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

///// Arrays, lists, and dictionaries
/*
 * Lists
 * Dynamically-sized arrays
 */
List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
list.Add(6); // Add 6 to the end of the list
list.Insert(0, 0); // Insert 0 at the beginning of the list
list.RemoveAt(0); // Remove the first element
list.Remove(6); // Remove the element with value 6
list.Sort(); // Sort the list
list.Reverse(); // Reverse the list
list.Clear(); // Remove all elements
list.Contains(3); // Check if the list contains 3
list.IndexOf(3); // Get the index of 3
Console.WriteLine(list.Count); // Get the number of elements in the list

/*
 * Arrays
 * Fixed-sized collections of data
 */
int[] array = new int[5] { 1, 2, 3, 4, 5 };
array[0] = 0; // Set the first element to 0
Console.WriteLine(array.Length); // Get the number of elements in the array

// Displaying content in lists or arrays
// Method 1: for loop
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

// Method 2: foreach loop
foreach (int i in list)
{
    Console.WriteLine(i);
}

/*
 * Dictionaries
 * A data type that stores values in key-value pairs
 */
Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("one", 1); // Add a key-value pair; will error if key already exists
dict["two"] = 2; // Add a key-value pair; will overwrite if key already exists, or add if it doesn't
dict.Remove("one"); // Remove the key-value pair with key "one"

// Displaying content in dictionaries
foreach (KeyValuePair<string, int> pair in dict)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

// Getting keys and values separately in dictionary
Dictionary<string, int>.KeyCollection keys = dict.Keys;
Dictionary<string, int>.ValueCollection values = dict.Values;

///// Dates
DateTime date = DateTime.Now; // Current date and time
DateTime specificDate = new DateTime(2020, 1, 1); // Specific date
Console.WriteLine(date); // Display date
Console.WriteLine(date.ToString("MM/dd/yyyy")); // Display formatted date

DateTime convertedDate = Convert.ToDateTime("01/01/2020"); // Convert string to date

// Date arithmetic
DateTime oneWeekLater = date.AddDays(7); // Add 7 days
DateTime newYears = new DateTime(date.Year, 1, 1);
int daysToNewYears = newYears.Subtract(date).Days; // Get the number of days until New Years

///// I/O
// Reading from a file
string[] lines = File.ReadAllLines("file.txt"); // Read all lines into an array
string text = File.ReadAllText("file.txt"); // Read all text into a string

// Read using StreamReader
// More efficient than File.ReadAllLines and File.ReadAllText and allows for more control
using (StreamReader sr = new StreamReader("file.txt"))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// Writing to a file
// Default directory is <project directory>\bin\Debug\<.NET version>; to override, use absolute path
File.WriteAllLines("file.txt", lines); // Write all lines from an array
File.WriteAllText("file.txt", text); // Write all text from a string