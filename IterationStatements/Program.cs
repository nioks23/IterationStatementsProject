using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            int init = 0;



            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                init++;

                // Then add your variable to "numbers"
                numbers.Add(init);
                Console.WriteLine(init);

                // While your variable is less than 100
            } while (init < 100);




            //Create a variable of type int and initialize the variable with a value of 0
            

            // Create a while loop
            // While your variable is less than 200
            while( init < 200)
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
                init++;
                numbers.Add(init);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            // Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(i);
            }
        }
    }
}
