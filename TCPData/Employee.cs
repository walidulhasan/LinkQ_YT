using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public decimal AnnulSalary { get; set; } = decimal.MaxValue;
    public bool IsManager { get; set; }
    public int DepartmentId { get; set; }
}
