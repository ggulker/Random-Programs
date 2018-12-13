//Garrett Gulker
//Due Date: 9/10/18
//readin three numbers using a console app and find 
//sum, average, smallest, and largest of the numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declerations for inputting and changing nums
            int number1, number2, number3;
            string firstNum, secondNum, thirdNum;
            Console.WriteLine("Input three whole numbers into the console and press enter after each number.");
            //reads nums in as strings
            firstNum = Console.ReadLine();
            secondNum = Console.ReadLine();
            thirdNum = Console.ReadLine();
            //changing read in nums to ints
            number1 = Int32.Parse(firstNum);
            number2 = Int32.Parse(secondNum);
            number3 = Int32.Parse(thirdNum);
            //declerations for calculations
            int sum, avg, smallest, largest;

            //finds the sum of the three numbers
            sum = number1 + number2 + number3;
            Console.WriteLine("Sum of Numbers: {0}", sum);

            //finds the average of the sum 
            avg = sum / 3;
            Console.WriteLine("Average of Numbers: {0}", avg);

            //starts with the first number as the smallest then if it finds a smaller one
            //it is replaced
            smallest = number1;
            if (smallest > number2)
                smallest = number2;
            if (smallest > number3)
                smallest = number3;
            Console.WriteLine("Smallest of the Numbers: {0}", smallest);

            //finds the largest number the same way as the smallest
            largest = number1;
            if (largest < number2)
                largest = number2;
            if (largest < number3)
                largest = number3;
            Console.WriteLine("Largest of the Numbers: {0}", largest);
        }
    }
}
