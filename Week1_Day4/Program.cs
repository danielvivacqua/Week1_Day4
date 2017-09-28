using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //A string is a sequence of characters
            //inside "double quotes"

            //Console.WriteLine("This is a tab \t.");
            //Console.WriteLine("This is a \"quote\".");
            //Console.WriteLine("This is a backslash \\");
            //Console.WriteLine("This is a \n new line.");
            //Console.WriteLine("And this is a bell \a");

            //Console.WriteLine("My name is {0} and my dog is {1}.", firstName, dogName);

            //string bestFriends = firstName + " " + dogName;

            string firstName = "Daniel";
            string dogName = "Gus";

            string bestFriends = string.Concat(firstName, dogName);
            Console.WriteLine(bestFriends);

            int danielLength = firstName.Length;

            Console.WriteLine(danielLength);
            Console.WriteLine(bestFriends.Length);
        }
    }
}
