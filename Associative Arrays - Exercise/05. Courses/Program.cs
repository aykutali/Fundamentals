namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = "";
            while ((command=Console.ReadLine())!="end")
            {
                List<string> argument=command
                    .Split(" : ").ToList();

                string courseName = argument[0];
                string student = argument[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName,new List<string>());
                }

                courses[courseName].Add(student);
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}