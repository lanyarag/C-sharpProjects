namespace rectangle
{
    internal class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ReadData();
            rectangle.CalcArea();
            rectangle.CalcPerimeter();
            rectangle.CalcDiagonal();
        }
    }
}