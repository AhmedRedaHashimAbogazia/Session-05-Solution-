using System;
using System.Data;
using static System.Console;

WriteLine("Hello, World!");

#region Q1 : Day of the Week
/*
Then write a program that:
•	Asks the user to enter a day number (0–6).•	Converts it to the enum and prints the day name.•	Uses a switch statement to print whether it's a "Workday" or a "Weekend".*/

int dayNumber;
WriteLine("Enter a day number (1-7):");
while (!int.TryParse(ReadLine(), out dayNumber) || dayNumber < 1 || dayNumber > 7)
{
    WriteLine("Invalid input. Please enter a number between 1 and 7.");
}
DayOfWeek day = (DayOfWeek)(dayNumber - 1);
WriteLine($"The day is: {day}");
switch (day)
{
    case DayOfWeek.Saturday:
    case DayOfWeek.Friday:
        WriteLine("It's a Weekend.");
        break;
    default:
        WriteLine("It's a Workday.");
        break;
}
#endregion

#region Q1 : Array Statistics
/*
Write a program that:
•	Asks the user for the size of an integer array.•	Reads the elements from the user.•	Prints: the sum, the average, the maximum value, the minimum value, and the array in reverse order.*/
WriteLine("Enter the size of the array:");
int size = int.Parse(ReadLine()!);
int[] nums = new int[size];
for (int i = 0; i < nums.Length; i++)
{
    Write($"Enter number {i + 1}: ");
    nums[i] = int.Parse(ReadLine()!);
}

WriteLine($"Sum: {nums.Sum()}");
WriteLine($"Average: {nums.Average()}");
WriteLine($"Maximum: {nums.Max()}");
WriteLine($"Minimum: {nums.Min()}");
WriteLine("Array in reverse order:");
for (int i = size - 1; i >= 0; i--)
{
    Write($"{nums[i]} ");
}
WriteLine();
#endregion

#region Q2 : Student Grades Matrix
/*
You have 3 students, each with 4 subject grades. Store them in a 2D array.Write a program that:
•	Reads grades from the user into a [3, 4] array.•	Prints each student's average grade.•	Prints the overall class average.*/
WriteLine("Enter grades for 3 students, each with 4 subjects:");
double[,] grades = new double[3, 4];
for (int i = 0; i < grades.GetLength(0); i++)
{
    for (int j = 0; j < grades.GetLength(1); j++)
    {
        Write($"Student {i + 1}, Subject {j + 1}: ");
        grades[i, j] = double.Parse(ReadLine()!);
    }
}
for (int i = 0; i < grades.GetLength(0); i++)
{
    double studentAverage = 0;
    for (int j = 0; j < grades.GetLength(1); j++)
    {
        studentAverage += grades[i, j];
    }
    studentAverage /= grades.GetLength(1);
    WriteLine($"Student {i + 1} Average: {studentAverage:F2}");
}
double classTotal = 0;
foreach (double grade in grades)
{
    classTotal += grade;
}
double classAverage = classTotal / grades.Length;
WriteLine($"Overall Class Average: {classAverage:F2}");
#endregion