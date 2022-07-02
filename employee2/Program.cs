namespace Employee2
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.ReadData();
            employee.PrintData();
            employee.SalaryIncrease();
        }
    }
}