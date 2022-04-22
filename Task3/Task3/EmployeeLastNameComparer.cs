using System.Collections;

public class EmployeeLastNameComparer : IComparer
{
    public int Compare(object a, object b)
    {
        return (new CaseInsensitiveComparer()).Compare(((Employee)a).LastName, ((Employee)b).LastName);
    }
}
