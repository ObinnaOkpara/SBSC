using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question3
{
    class Program
    {
        //3. Given a string compute how many times a letter occurs in the string and
        //return it formatted such that every non-repeated letter in the string is
        //followed by its number of occurrences.
        //Example:
        //Input: occurrence
        //Output: o1c3u1r2e2n1
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'input string'.");
            var inputString = Console.ReadLine();

            var characterGroup = inputString.GroupBy(m => m);
            var outputStringBuilder = new StringBuilder();

            foreach (var group in characterGroup)
            {
                outputStringBuilder.Append($"{group.Key}{group.Count()}");
            }

            Console.WriteLine(outputStringBuilder.ToString());

            //Please uncomment the lines below is your console closes automatically.
            //Console.WriteLine("Press ENTER to close this window.");
            //Console.ReadLine();

        }
    }
}
