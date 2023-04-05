using System;

namespace Loops_Wilson_Kenny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberofSpaces(response)} spaces in it. ");

            Console.WriteLine("Please enter a whole number!");
            string response2 = Console.ReadLine();
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns>Number of spaces in the sentence</returns>
        static int CountNumberofSpaces(string sentence)
            
            
        {
            int numberofSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                 numberofSpaces++;
                
            }
            return numberofSpaces;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">Sums the number of digits</param>
        /// <returns></returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digits in number)
            {
                sum += (int)Char.GetNumericValue(digits);
            }
                return sum;
            
        }

    }
}
