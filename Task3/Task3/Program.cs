class Task3
{
    static void Main()
    {
        Employee JohnSmith = new Employee("John", "Smith", "Chicago", 5800);
        Employee AliceWood = new Employee("Alice", "Wood", "Ohio", 3200);
        Employee MatGold = new Employee("Mat", "Gold", "Texas", 4500);
        Employee[] employees = new Employee[] { JohnSmith, AliceWood, MatGold };
        foreach (Employee employee in employees) Console.WriteLine(employee.LastName + " - " + employee.Salary);
        Console.WriteLine("-------Sort By Last Name--------");
        Array.Sort(employees, new EmployeeLastNameComparer());
        foreach (Employee employee in employees) Console.WriteLine(employee.LastName + " - " + employee.Salary);
        Console.WriteLine("-------Sort By Salary--------");
        Array.Sort(employees, new EmployeeSalaryComparer());
        foreach (Employee employee in employees) Console.WriteLine(employee.LastName + " - " + employee.Salary);
    }
}
