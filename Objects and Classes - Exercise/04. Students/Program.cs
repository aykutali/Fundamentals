using System.Dynamic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> input=Console.ReadLine()
                    .Split()
                    .ToList();

                Student currStudent = new Student(input[0], input[1], input[2]);

                students.Add(currStudent);
            }

            List<Student> newList = students.OrderByDescending(x => x.Grade).ToList();
            

            foreach (var item in newList)
            {
                item.Print();
            }
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, string grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = double.Parse(grade);
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }

    public void Print()
    {
        Console.WriteLine($"{FirstName} {LastName}: {Grade:F2}");
    }
}


    