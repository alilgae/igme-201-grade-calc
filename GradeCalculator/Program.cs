/*
 * Kaiden Terrana
 * IGME 201
 * Due Oct 13, 2024
 */

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            string studentName = "Kaiden";
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            float average = 0;

            // introduction
            Console.WriteLine("Welcome, " + studentName);
            Console.WriteLine("Here are your grades: \n");

            // loop through each grade 
            foreach (int grade in grades)
            {
                // print out the grade 
                Console.WriteLine(grade);

                // print letter grade
                if (grade > 100) Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                else if (grade >= 90)
                {
                    Console.WriteLine("This grade is an A!");
                    if (grade == 100) Console.WriteLine("WOW! A perfect score!");
                }
                else if (grade >= 80) Console.WriteLine("This grade is a B.");
                else if (grade >= 70) Console.WriteLine("This grade is a C.");
                else if (grade >= 65) Console.WriteLine("This grade is a D.");
                else if (grade >= 0) Console.WriteLine("This grade is an F.");
                else Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");

                // increment average
                average += grade;
            }

            // divide by total grades
            average /= grades.Length;


            // display average 
            Console.WriteLine("Your final calculated average is: " + average);

            // closing 
            Console.WriteLine("All grades for " + studentName + " have been displayed.");
        }
    }
}
