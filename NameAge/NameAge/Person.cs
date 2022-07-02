

namespace NameAge
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public void CaptureData()
        {
            Console.WriteLine("What's your name?");
            Name = Console.ReadLine();

            int age;
            Console.WriteLine("How old are you?");
            Age = int.Parse(Console.ReadLine());

        }
    }
}