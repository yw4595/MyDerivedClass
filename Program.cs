using System;

namespace MyDerivedClass
{
    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: This class defines a base class with a private field and a public virtual method.
    /// Restrictions: None.
    /// </summary>
    public class MyClass
    {
        private string myString; // Private field to store the string

        /// <summary>
        /// Property to set the value of myString.
        /// </summary>
        public string MyString
        {
            set { myString = value; }
        }

        /// <summary>
        /// Method to return the string stored in myString.
        /// </summary>
        /// <returns>The value of myString.</returns>
        public virtual string GetString()
        {
            return myString;
        }
    }

    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: This class derives from MyClass and overrides the GetString() method to append some text to the base class's implementation.
    /// Restrictions: None.
    /// </summary>
    public class MyDerivedClass : MyClass
    {
        /// <summary>
        /// Method to return the string stored in myString with additional text appended to it.
        /// </summary>
        /// <returns>The value of myString with additional text appended to it.</returns>
        public override string GetString()
        {
            string baseString = base.GetString();
            return baseString + " (output from the derived class)";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedClass = new MyDerivedClass();
            derivedClass.MyString = "Hello World!";
            string outputString = derivedClass.GetString();
            Console.WriteLine(outputString);
            // Output: Hello World! (output from the derived class)
        }
    }
}
