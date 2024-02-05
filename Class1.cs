/*******************************************************************************  
 * Kean University  
 * Spring 2024
 * Course: CPS*3300*01 - Software Development with Frameworks
 * Author: Allan Lozano Bardales, CPS*3300, 01 
 * Lab #2 Create and Test a Library App
 *******************************************************************************/

namespace MyAverageLibrary
{
    public class Average
    {
        public static void MyAverage(double a, double b)
        {
            double average2 = (a + b) / 2;//Calculate the average of the two user input

            // Using composite String
            Console.WriteLine("Provided values: {0:f2} and {1:f2}, the average is {2:f2}\n", a, b, average2);
        }
        public static void MyAverage(double a, double b, double c)
        {
            double average3 = (a + b + c) / 3;//Calculate the average of the three user input

            // Using composite String to display the message
            Console.WriteLine("Provided values: {0:f2}, {1:f2}, and {2:f2}, the average is {3:f2}", a, b, c, average3);
        }
    }
}
