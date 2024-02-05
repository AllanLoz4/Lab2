/*******************************************************************************  
 * Kean University  
 * Spring 2024
 * Course: CPS*3300*01 - Software Development with Frameworks
 * Author: Allan Lozano Bardales, CPS*3300, 01 
 * Lab #2 Create and Test a Library App
 *******************************************************************************/

using System;
using MyAverageLibrary;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of numbers you will provide: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for 'a' and press enter: ");//Ask user to input first value
            double a = Convert.ToDouble(Console.ReadLine());//Read the user input value

            Console.WriteLine("Enter value for 'b' and press enter: ");//Ask user to input second value
            double b = Convert.ToDouble(Console.ReadLine());//Read the user input vlaue

            if (num == 2)
            {
                MyAverageLibrary.Average.MyAverage(a, b);
            }
            
            else if (num == 3)
            {
                Console.WriteLine("Enter value for 'c' and press enter: ");//Ask user to input third value
                double c = Convert.ToDouble(Console.ReadLine());//Read the user input value

                MyAverageLibrary.Average.MyAverage(a, b, c);
            }
            else
            {
                Console.WriteLine("Invalid number of inputs.");
            }
        }
    }
}