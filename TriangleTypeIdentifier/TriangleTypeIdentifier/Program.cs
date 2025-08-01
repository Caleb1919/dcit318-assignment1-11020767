using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Triangle Type Identifier");
        Console.WriteLine("------------------------");

        bool continueChecking = true;

        while (continueChecking)
        {
            Console.WriteLine("\nEnter the lengths of the three sides of the triangle:");

            // Get and validate three side lengths
            if (GetValidSide("Side 1: ", out double side1) &&
                GetValidSide("Side 2: ", out double side2) &&
                GetValidSide("Side 3: ", out double side3))
            {
                // Check if these sides can form a valid triangle
                if (IsValidTriangle(side1, side2, side3))
                {
                    // Determine and display triangle type
                    string triangleType = DetermineTriangleType(side1, side2, side3);
                    Console.WriteLine($"\nThis is a {triangleType} triangle.");
                }
                else
                {
                    Console.WriteLine("\nError: These sides cannot form a valid triangle.");
                    Console.WriteLine("The sum of any two sides must be greater than the third side.");
                }
            }

            // Ask if user wants to continue
            Console.Write("\nCheck another triangle? (Y/N): ");
            string response = Console.ReadLine().Trim().ToUpper();

            if (response != "Y")
            {
                continueChecking = false;
            }
        }

        Console.WriteLine("\nThank you for using the Triangle Type Identifier!");
    }

    static bool GetValidSide(string prompt, out double side)
    {
        side = 0;
        Console.Write(prompt);

        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out side))
            {
                if (side > 0)
                {
                    return true;
                }
                else
                {
                    Console.Write("Side length must be positive. Please re-enter: ");
                }
            }
            else
            {
                Console.Write("Invalid input. Please enter a number: ");
            }
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static string DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Equilateral (all sides equal)";
        }
        else if (a == b || a == c || b == c)
        {
            return "Isosceles (two sides equal)";
        }
        else
        {
            return "Scalene (no sides equal)";
        }
    }
}