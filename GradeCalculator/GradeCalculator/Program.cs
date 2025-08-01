using System;

class GradeConverter
{
    static void Main()
    {
        Console.WriteLine("Grade Converter Program");
        Console.WriteLine("-----------------------");

        bool continueConversion = true;

        while (continueConversion)
        {
            // user is enter grade scord
            Console.Write("\nEnter a numerical grade (0-100): ");

            // Read input and try to convert to integer
            if (int.TryParse(Console.ReadLine(), out int numericalGrade))
            {
                // Validate input range
                if (numericalGrade >= 0 && numericalGrade <= 100)
                {
                    // Determine letter grade
                    string letterGrade = GetLetterGrade(numericalGrade);

                    // Display result
                    Console.WriteLine($"Letter grade: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }

            // Ask if user wants to continue
            Console.Write("\nConvert another grade? (Y/N): ");
            string response = Console.ReadLine().Trim().ToUpper();

            if (response != "Y")
            {
                continueConversion = false;
            }
        }

        Console.WriteLine("\nThank you for using the Grade Converter!");
    }

    static string GetLetterGrade(int grade)
    {
        if (grade >= 90)
            return "A";
        else if (grade >= 80)
            return "B";
        else if (grade >= 70)
            return "C";
        else if (grade >= 60)
            return "D";
        else
            return "F";
    }
}