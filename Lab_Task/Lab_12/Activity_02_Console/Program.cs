using System;

namespace Activity_02_Console
{
    public class StudentClass
    {
        protected enum GradeLevel
        {
            FirstYear = 1,
            SecondYear,
            ThirdYear,
            FourthYear
        };

        protected class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int ID { get; set; }
            public GradeLevel Year;
            public List<int> ExamScores;
        }

        protected static List<Student> students = new List<Student>()
        {
            new Student {FirstName = "Terry",LastName = "Adams",ID = 120,Year = GradeLevel.SecondYear,ExamScores = new List<int>() { 99,82,81,79} },
            new Student { FirstName = "John", LastName = "Doe", ID = 101, Year = GradeLevel.FirstYear, ExamScores = new List<int>() { 88, 75, 92, 84 } },
            new Student { FirstName = "Alice", LastName = "Smith", ID = 102, Year = GradeLevel.ThirdYear, ExamScores = new List<int>() { 91, 85, 78, 83 } },
            new Student { FirstName = "Bob", LastName = "Johnson", ID = 103, Year = GradeLevel.FourthYear, ExamScores = new List<int>() { 95, 80, 89, 76 } },
            new Student { FirstName = "Emma", LastName = "Brown", ID = 104, Year = GradeLevel.FirstYear, ExamScores = new List<int>() { 78, 85, 91, 88 } },
            new Student { FirstName = "Michael", LastName = "Williams", ID = 105, Year = GradeLevel.ThirdYear, ExamScores = new List<int>() { 84, 90, 92, 78 } },
            new Student { FirstName = "Sophia", LastName = "Miller", ID = 106, Year = GradeLevel.FirstYear, ExamScores = new List<int>() { 85, 79, 82, 88 } },
            new Student { FirstName = "James", LastName = "Davis", ID = 107, Year = GradeLevel.FourthYear, ExamScores = new List<int>() { 91, 88, 85, 90 } },
            new Student { FirstName = "Olivia", LastName = "Garcia", ID = 108, Year = GradeLevel.FourthYear, ExamScores = new List<int>() { 87, 89, 92, 80 } }

        };

        protected static int GetPercentile(Student s)
        {
            double avg = s.ExamScores.Average();
            return avg > 0 ? (int)avg / 10 : 0;
        }

        public void QueryHighSecores(int exam,int score)
        {
            var highScores = from student in students where student.ExamScores[exam] > score select new { Name=student.FirstName,Score = student.ExamScores[exam] };
            foreach(var item in highScores)
            {
                Console.WriteLine($"Name : {item.Name},  Score: {item.Score}");
            }
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            StudentClass student = new StudentClass();
            student.QueryHighSecores(0, 90);
        }
    }

}
