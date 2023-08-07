namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people= new List<Person>();

            string command = "";
            while ((command=Console.ReadLine())!="End")
            {
                List<string> input=command
                    .Split()
                    .ToList();

                Person currPerson = new Person(input[0], input[1], int.Parse(input[2]));

                bool isAlreadyHaveThisID= false;
                foreach (var person in people)
                {
                    if (currPerson.ID==person.ID)
                    {
                        person.Name = currPerson.Name;
                        person.Age = currPerson.Age;
                        isAlreadyHaveThisID=true;
                        break;
                    }
                }

                if (!isAlreadyHaveThisID)
                {
                    people.Add(currPerson);
                }
            }

            List<Person> sortedPeoples= new List<Person>();

            sortedPeoples=people.OrderBy(x => x.Age).ToList();

            foreach (var person in sortedPeoples)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name,string id,int age)
        {
            Name=name;
            ID=id;
            Age=age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
}