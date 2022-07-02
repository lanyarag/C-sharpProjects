
namespace rectangle
{
    public class Rectangle
    {
        double Width { get; set; }
        double Height { get; set; }

        public void ReadData()
        {
            Console.WriteLine("Put the data of the rectangle.");
            Console.WriteLine("Width: ");
            Width = double.Parse(Console.ReadLine());
            Console.WriteLine("Heigth: ");
            Height = double.Parse(Console.ReadLine());
        }

        public void CalcArea()
        {
            double Area = Width * Height;
            Console.WriteLine($"A rectangle with height {Height} e width {Width} has area {Area}");
        }

        public void CalcPerimeter()
        {
            double Perimeter = 2*(Width + Height);
            Console.WriteLine($"A rectangle with height {Height} e width {Width} has perimeter {Perimeter}");
        }

        public void CalcDiagonal()
        {
            double Diagonal;
            Diagonal = Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
            Console.WriteLine($"A rectangle with height {Height} e width {Width} has diagonal {Diagonal}");
        }
    }
}
