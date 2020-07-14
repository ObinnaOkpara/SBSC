using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SBSC
{
    class Program
    {
        //1. Given a string of hyphen separated numbers return true where k is the same
        //for all numbers otherwise return false.
        //k is the interval between a number and the next.
        //Example1:
        //Inputs:
        //Sample string: “1-2-2-4-5”
        //Output: False.
        //Example2:
        //Input:
        //Sample string:”3-4-5-6-7”
        //Output: True.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input string.");
            var inputString = Console.ReadLine();
            try
            {

                var stringArray = inputString.Split('-');

                var intArray = stringArray.Select(m => int.Parse(m)).ToArray();

                if (intArray.Length < 2)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    var k = intArray[1] - intArray[0];

                    for (int i = 1; i < intArray.Length; i++)
                    {
                        if (k != (intArray[i] - intArray[i - 1]))
                        {
                            Console.WriteLine("False");

                            //Please uncomment the lines below is your console closes automatically.
                            //Console.WriteLine("Press ENTER to close this window.");
                            //Console.ReadLine();

                            return;
                        }
                    }

                    Console.WriteLine("True");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Input format error! Expected Hyphen Separated integers.");
            }
            //Please uncomment the lines below is your console closes automatically.
            //Console.WriteLine("Press ENTER to close this window.");
            //Console.ReadLine();
        }


    }
}
