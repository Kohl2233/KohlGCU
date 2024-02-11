namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Scores
            int[] scores = { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

            // Score Printing
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            // Pause Program End
            Console.ReadLine();

            // Using LINQ
            var theBestStudents = from score in scores where score > 90 select score;

            foreach (var score in  theBestStudents)
            {
                Console.WriteLine(score);
            }

            // Pause
            Console.ReadLine();

            // Using LINQ Sorting
            var sortedScores = from score in scores orderby score select score;

            // Print Sorted Scores
            foreach (var score in sortedScores)
            {
                Console.WriteLine(score);
            }

            // Pause
            Console.ReadLine();

            // Print only List of B Students
            var averageStudents = from score in scores where score > 79 && score < 90 select score;
            foreach (var score in averageStudents)
            {
                Console.WriteLine(score);
            }

            // Pause
            Console.ReadLine();

            // CompareTo Demonstration
            List<Student> students = new List<Student>();
            students.Add(new Student("Kohl Johnson", 23, 92));
            students.Add(new Student("John Sno", 21, 30));
            students.Add(new Student("Pete Peter", 25, 49));
            students.Add(new Student("Chris Mills", 28, 67));
            students.Add(new Student("Darrell Summer", 32, 100));
            students.Add(new Student("Martha Stones", 19, 90));
            students.Add(new Student("Chewy Kirbs", 23, 91));
            students.Add(new Student("Buck Season", 22, 76));
            students.Add(new Student("Charlie Joe", 25, 88));
            students.Add(new Student("Melvin Mahlin", 30, 45));

            var sortedStudents = from student in students orderby student ascending select student;

            foreach (var student in sortedStudents) { Console.WriteLine("{0}, {1}, Score: {2}", student.name, student.age, student.grade); }

        }
    }
}