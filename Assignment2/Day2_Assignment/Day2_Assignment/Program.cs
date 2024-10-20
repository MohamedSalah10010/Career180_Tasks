using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read data and store it in a 2D array
            double[,] studentData = ReadData();

            // Evaluate and print subject-wise grades
            subjectsEvaluation(studentData);

            // Evaluate and print total grade for each student
            totalEvaluation(studentData);

            // Print IDs of students who failed in more than two subjects
            printFailures(studentData);
        }

        // Method to read student data (IDs and scores)
        public static double[,] ReadData()
        {
            Console.Write("Enter the number of students: ");
            int numOfStudents = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of subjects: ");
            int numOfSubjects = int.Parse(Console.ReadLine());

            // Create a 2D array with one extra column for Student IDs
            double[,] studentData = new double[numOfStudents, numOfSubjects + 1];

            for (int i = 0; i < numOfStudents; i++)
            {
                // Input Student ID
                Console.Write($"Enter the ID for student {i + 1}: ");
                studentData[i, 0] = double.Parse(Console.ReadLine()); // First column stores the student ID

                // Input scores for the student
                Console.WriteLine($"Enter the scores for {numOfSubjects} subjects (separated by a comma) for Student ID {studentData[i, 0]}:");
                string input = Console.ReadLine();
                string[] parts = input.Split(',');

                // Store subject scores in the subsequent columns
                for (int j = 0; j < numOfSubjects; j++)
                {
                    studentData[i, j + 1] = double.Parse(parts[j]);
                }
            }

            return studentData;  // Return the 2D array containing student IDs and subject scores
        }

        // Method to evaluate and print total grade for each student
        public static void totalEvaluation(double[,] studentData)
        {
            int numOfStudents = studentData.GetLength(0); // Number of students (rows)
            int numOfSubjects = studentData.GetLength(1) - 1; // Exclude ID column for subjects

            // Arrays to store total grades and final letter grades for each student
            double[] totalGrades = new double[numOfStudents];
            char[] finalGrades = new char[numOfStudents];

            // Calculate total grades and assign a final letter grade
            for (int i = 0; i < numOfStudents; i++)
            {
                double sum = 0;
                for (int j = 1; j <= numOfSubjects; j++)  // Start from column 1 to skip the ID column
                {
                    sum += studentData[i, j];  // Sum all subject grades for each student
                }

                double average = sum / numOfSubjects;  // Calculate average score
                totalGrades[i] = average;

                // Assign letter grades based on average
                if (average >= 85) finalGrades[i] = 'A';
                else if (average >= 70) finalGrades[i] = 'B';
                else if (average >= 65) finalGrades[i] = 'C';
                else if (average >= 50) finalGrades[i] = 'D';
                else finalGrades[i] = 'F';
            }

            // Print total grades for each student
            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine($"Total Grade for student ID: {studentData[i, 0]} is {finalGrades[i]}");
            }
        }

        // Method to evaluate and print subject-wise grades for each student
        public static void subjectsEvaluation(double[,] studentData)
        {
            int numOfStudents = studentData.GetLength(0); // Number of students (rows)
            int numOfSubjects = studentData.GetLength(1) - 1; // Exclude ID column for subjects

            // Create a 2D array to store subject-wise letter grades
            char[,] evalGrades = new char[numOfStudents, numOfSubjects];

            // Assign letter grades for each subject
            for (int i = 0; i < numOfStudents; i++)
            {
                for (int j = 0; j < numOfSubjects; j++)
                {
                    double score = studentData[i, j + 1]; // Access scores (skip ID)
                    if (score >= 85) evalGrades[i, j] = 'A';
                    else if (score >= 70) evalGrades[i, j] = 'B';
                    else if (score >= 65) evalGrades[i, j] = 'C';
                    else if (score >= 50) evalGrades[i, j] = 'D';
                    else evalGrades[i, j] = 'F';
                }
            }

            // Print subject-wise grades for each student
            for (int i = 0; i < numOfStudents; i++)
            {
                Console.Write($"Grades for student ID: {studentData[i, 0]}: ");
                for (int j = 0; j < numOfSubjects; j++)
                {
                    Console.Write($"{evalGrades[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        // Method to print IDs of students who failed in more than two subjects
        public static void printFailures(double[,] studentData)
        {
            int numOfStudents = studentData.GetLength(0); // Number of students (rows)
            int numOfSubjects = studentData.GetLength(1) - 1; // Exclude ID column for subjects

            // Array to store the IDs of students who failed more than two subjects
            List<int> failureIDs = new List<int>();

            // Evaluate failures
            for (int i = 0; i < numOfStudents; i++)
            {
                int failCount = 0;
                for (int j = 1; j <= numOfSubjects; j++)  // Start from column 1 to skip the ID column
                {
                    if (studentData[i, j] < 50) failCount++;  // Count failures in each subject
                }

                // If a student fails more than two subjects, add their ID to the list
                if (failCount > 2) failureIDs.Add((int)studentData[i, 0]);
            }

            // Print IDs of students who failed in more than two subjects
            if (failureIDs.Count > 0)
            {
                Console.WriteLine("Students who failed in more than two subjects (IDs): " + string.Join(", ", failureIDs));
            }
            else
            {
                Console.WriteLine("No student failed in more than two subjects.");
            }
        }
        public static void Print2DArray(double[,] array)
        {
            int rows = array.GetLength(0); // Number of students (rows)
            int cols = array.GetLength(1); // Number of subjects + 1 (ID column)

            // Print column headers
            Console.Write(" ID  |");
            for (int col = 1; col < cols; col++)
            {
                Console.Write($" Sub{col} | ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', (cols + 1) * 8)); // Print a separator line

            // Print rows with student IDs and scores
            for (int row = 0; row < rows; row++)
            {
                Console.Write($"{array[row, 0],-4} |"); // Print student ID

                for (int col = 1; col < cols; col++)
                {
                    // Print each score aligned within a cell
                    Console.Write($"  {array[row, col],-5}|");
                }
                Console.WriteLine(); // Move to the next row after printing the current row
            }
        }
    }
}
