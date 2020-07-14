using System;
using System.Collections.Generic;
using System.Linq;

namespace Question2
{
    class Program
    {
        //2. Given an ordered list of integers you are expected to find the absolute
        //difference D, then insert D into the list.Do this until the difference between
        //all integers exist in the list then return the Kth integer.If the Kth integer cannot
        //be found return -1.
        //Hint: no integer must exist more than once.
        //D is the absolute difference between an integer and the next.
        //K is the position of an integer in the list.
        //Example1:
        //Inputs:
        //List of integers[1, 4, 6, 9]
        //Value of K: 3
        //Output: 7
        //Example2:
        //Inputs:
        //List of integers[1, 2]
        //Value of K: 5
        //Output: -1
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input list of integer as COMMA SEPARATED STRING.");
            var inputString = Console.ReadLine();

            try
            {
                Console.WriteLine("Enter a value if 'K'.");
                var k = int.Parse(Console.ReadLine());

                var listOfInt = inputString.Split(',').Select(m => int.Parse(m.Trim())).ToList();

                listOfInt = FillMissingNumbers(listOfInt);

                if (listOfInt.Count < k)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    //display Kth item which is at index (K - 1)
                    Console.WriteLine(listOfInt[k - 1]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input format error! Expected Comma Separated integers.");
            }
        }
        /// <summary>
        /// Pass in a list of integers, it returns a list of integers filling in missing values according to the rule.
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        private static List<int> FillMissingNumbers(List<int> intList)
        {
            bool changed = true;
            //if the list contains one item, return it the way it is.
            if (intList.Count <= 1)
            {
                return intList;
            }

            //check if any change was made to the list.
            while (changed)
            {
                //reset check variable
                changed = false;

                for (int i = 0; i < intList.Count - 1; i++)
                {
                    //D is the absolute difference between an integer and the next.
                    var Diff = Math.Abs(intList[i] - intList[i + 1]);

                    //if the list does not contain D
                    if (!intList.Contains(Diff))
                    {
                        //add D to the list
                        intList.Add(Diff);
                        //Notify list change
                        changed = true;
                        //Sort the list to maintain an ordered list
                        intList.Sort();
                        //break
                        break;
                    }
                }
            }

            //return the list when the loop and check is completed without a change.
            return intList;
        }
    }
}
