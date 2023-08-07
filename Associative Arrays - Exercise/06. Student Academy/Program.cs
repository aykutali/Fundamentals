namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                Student currStudent = new Student(studentName, grade);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, currStudent);
                }
                else
                {
                    students[studentName].AddGrade(grade);
                }
            }

            var betterStudents = new Dictionary<string, Student>();
            foreach (var student in students)
            {
                if (student.Value.AverageGrade>=(decimal)4.5)
                {
                    betterStudents.Add(student.Key,student.Value);
                }
            }
            
            foreach (var student in betterStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.AverageGrade:F2}");
            }
        }
    }

    public class Student
    {
        public Student(string name, decimal grade)
        {
            Name = name;
            AddGrade(grade);
        }

        public string Name { get; set; }

        public List<decimal> Grades { get; set; } = new List<decimal>();

        public decimal AverageGrade { get; set; }

        public void AddGrade(decimal grade) 
        {
            Grades.Add(grade);
            AverageGrade = Grades.Sum() / Grades.Count;
        }
    }
}