using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Split().Select(int.Parse).ToList();

            while (!(input == "Odd") && !(input == "Even"))
            {
                input = Console.ReadLine();
                string[] commands = input.Split();

                if (commands[0] == "Delete")
                {
                    int element = int.Parse(commands[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }
            }
            if (input == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}