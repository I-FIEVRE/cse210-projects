using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         int number = -1;
         List<int> numbers = new List<int>();
         Console.WriteLine("Enter a list of numbers, type 0 when finished.");
         while (number != 0)
         {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);
         }
         //foreach (int num in numbers)
         //{
            //Console.WriteLine(num);
         //}
         numbers.RemoveAt(numbers.Count -1);

         int sum = numbers.Sum();
         Console.WriteLine("The sum is: " + sum);
         float sum1 = sum;
         float average = sum1 / numbers.Count;
         Console.WriteLine("The average is: " + average);

         int largestNumber = numbers.Max();
         Console.WriteLine("The largest number is: " + largestNumber);
    }
}