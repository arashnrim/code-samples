namespace CSharp
{
    /*
     * Classes
     * A data type that can contain data and methods
     * Access modifiers: public, private, protected, internal, protected internal
     * Name: PascalCase
     */
    internal class ClassExample
    {
        // Attributes: data that belongs to the class; usually private (encapsulation)
        private string name;
        private int age;
        private string assignedClass;

        // Properties: special methods that allow access to private attributes
        // Usually capitalized variants of the attribute name

        // Shorthand propery (where no validation is needed)
        public string Name { get; set; }
        public string AssignedClass { get; set; }

        // Full property (where validation is needed)
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid age. Age set to 0.");
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        // Constructor: special method that is called when an object is created
        // Usually has the same name as the class and no return type
        // Can have parameters, which are used to initialize the attributes
        public ClassExample(string name, int age, string assignedClass)
        {
            Name = name;
            Age = age;
            AssignedClass = assignedClass;
        }

        // Method: a function that belongs to a class
        public void ChangeAssignedClass(string newClass)
        {
            AssignedClass = newClass;
        }

        // ToString() method: special method that is called when an object is converted to a string
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Assigned Class: {AssignedClass}";
        }
    }
}
