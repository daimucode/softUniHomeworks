using System;
using System.Linq;

namespace mostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int counter = 0;
            long mostFrequent = 0;
            int topCount = 0;

            for (int inputChecker = 0; inputChecker < inputArray.Length; inputChecker++)
            {
                counter = 0;

                for (int checkingHit = 0; checkingHit < inputArray.Length; checkingHit++)
                {
                    if (inputArray[inputChecker] == inputArray[checkingHit])
                    {
                        counter++;

                        if (topCount < counter)
                        {
                            topCount += counter;
                            mostFrequent = inputArray[inputChecker];
                        }
                    }
                }
            }

            Console.WriteLine(mostFrequent);
        }
    }
}
