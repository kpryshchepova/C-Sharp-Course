using System.Collections;

public class EmployeeSalaryComparer : IComparer
{
    public int Compare(object a, object b)
    {
        return (new CaseInsensitiveComparer()).Compare(((Employee)a).Salary, ((Employee)b).Salary);
    }
}