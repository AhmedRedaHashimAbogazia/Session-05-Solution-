using S05SOL;
using static System.Console;

WriteLine("Hello, World!");

//Build a mini Student Grade Manager that combines all three topics.
double[] StudentGrades = new double[5];

//•	Read 5 student scores from the user.
for (int i = 0; i < StudentGrades.Length; i++)
{
    Write($"Enter grade for student {i + 1}: ");
    StudentGrades[i] = double.Parse(ReadLine()!);
}

//•	Print each student's score and corresponding letter grade.
for (int i = 0; i < StudentGrades.Length; i++)
{
    Grades grade = Functions.GetGrade(StudentGrades[i]);
    WriteLine($"Student {i + 1}: Score = {StudentGrades[i]}, Grade = {grade}");
}

//•	Print the class average, minimum, and maximum scores.
double average = Functions.GetAverageGrade(StudentGrades);
Functions.GetMinMax(StudentGrades, out double min, out double max);
WriteLine($"Class Average Score:{average}");
WriteLine($"Minimum Score: {min}");
WriteLine($"Maximum Score: {max}");