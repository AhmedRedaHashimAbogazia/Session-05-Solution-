namespace S05SOL;

public static class Functions
{
    public static Grades GetGrade(double score)
    {
        if (score >= 90)
            return Grades.A;
        else if (score >= 80)
            return Grades.B;
        else if (score >= 70)
            return Grades.C;
        else if (score >= 60)
            return Grades.D;
        else
            return Grades.F;
    }
    public static double GetAverageGrade(double[] grades)
    {
        double sum = 0;
        foreach (double grade in grades)
        {
            sum += grade;
        }
        return sum / grades.Length;
    }
    //) Method To GetMinMax finds the min and max scores using out.
    public static void GetMinMax(double[] grades, out double min, out double max)
    {
        min = grades.Min();
        max = grades.Max();
    }
}
