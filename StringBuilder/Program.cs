using System;
using System.Text;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //stringBuilder is a class in c# so, has properties and methods.
            //StringBuilder uses System.Text namespace
            //We use StringBuilder to change strings
            //StringBuilder is more efficient in terms of memory than using String methods

            //we need to instantiate an object
            /*StringBuilder newString = new StringBuilder();

            //Methods
            //add something to the string(in this case, an empty string)

            newString.Append('-', 6); //add dashes for 6 places
            newString.Append(" Here is a title! ");
            newString.Append('-', 6);

            newString.AppendLine();
            newString.Append("And here is a paragraph!");
            newString.Replace("And here is a paragraph!", "Whoops!");

            newString.Remove(0, 30);//remove first and 30th space, so moved everything!
            newString.Insert(0, "My name is Leeslie");*/

            //a much better way is to string all the methods together, chain them!
            StringBuilder newString2 = new StringBuilder("Hi, Leslie!");

            newString2.Append("How are you today?").AppendLine().Append("I am great!");




            Console.WriteLine(newString2);
        }
    }
}
