using System;
using System.Linq;

namespace Test_By_Nurudin
{
    class Program
    {
        private const string EMPTY_STRING_ERROR = "Empty string found. Please type some characters";
        static void Main()
        {
            START:
            Console.WriteLine("Please enter any string : ");
            string inputString = Console.ReadLine().ToLower();

            //Restart if string is empty
            if (string.IsNullOrEmpty(inputString))
            {
                Console.WriteLine(EMPTY_STRING_ERROR);
                goto START;
            }

            int maxOccurences = 0;
            char charecterMaxOcccured = ' ';

            //find maximum occurence
            foreach (char charecter in inputString.ToCharArray())
            {
                int occurences = inputString.Count(p => p == charecter);
                if (occurences > maxOccurences)
                {
                    maxOccurences = occurences;
                    charecterMaxOcccured = charecter;
                }
            }

            //print result
            Console.WriteLine($"Frequent character: \"{charecterMaxOcccured}\", count: {maxOccurences}");
            Console.ReadLine();
        }
    }
}
