
namespace Student
{
    public class Student
    {
        string Name;
        double Average;
        double SumScore;
        
        public double CaptData()
        {
            Console.WriteLine("Welcome to the program. What's your name?");
            Name = Console.ReadLine();
            Console.WriteLine("What was the grade for the first quarter?");
            double Score1 = double.Parse(Console.ReadLine());
            Console.WriteLine("What was the grade for the second quarter?");
            double Score2 = double.Parse(Console.ReadLine());
            Console.WriteLine("What was the grade for the third quarter?");
            double Score3 = double.Parse(Console.ReadLine());
            double SumScore = Score1 + Score2 + Score3;
            return SumScore;
        }
        public double CalcAverage()
        {
            Average = SumScore / 3;
            return Average;
        }

        public void Status()
        {
            if (Average > 60)
            {
                Console.WriteLine($"The student {Name} is approved. Congratulations!");
            }
            else
            {
                Console.WriteLine($"The student {Name} was not approved");
            }
        }

    }
}
