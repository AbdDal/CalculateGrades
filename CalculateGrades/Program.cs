using CalculateGrades;

class Program
{
    public static void Main(string[] args)
    {
        var gradeClass = new Grades();
        
        gradeClass.StartApplication();

        var command = Console.ReadLine();
        
        gradeClass.CheckCommand(command);
    }

}