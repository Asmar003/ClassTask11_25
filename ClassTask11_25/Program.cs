namespace ClassTask11_25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            Assistant assistant = new Assistant();

            employee.Name = "asmar";
            employee.Salary = 500;
            employee.IsSuccesful = true;

            Assistant.GetFeedBack(employee, assistant);
        }
    }
}