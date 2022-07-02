namespace NameAge
{
    internal class Program
    {
        static void Main()
        {
            string name;
            int age;

            Person person1 = new Person("",0);
            Person person2 = new Person("",0);

            person1.CaptureData();
            person2.CaptureData();

            if (person1.Age > person2.Age)
            {
                Console.WriteLine($"{person1.Name} is older than {person2.Age}");
            }
            else if (person1.Age < person2.Age)
            {
                Console.WriteLine($"{person2.Name} is older than {person2.Age}");
            }
            else
            {
                Console.WriteLine($"You are {person1.Age} years old");
            }

        }
    }
}