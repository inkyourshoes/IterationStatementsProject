using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); //DO NOT ERASE THIS! You will use this in the exercise.


            var num = 0;


            do
            {
                num++;

                numbers.Add(num);
            } while (num < 100);

            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }


            Console.WriteLine("Increase:");


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            for (int i = 199; i >= 0; i--)

                //for(int i = 199; 1 <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}