using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData;

public static class Data
{
    public static List<Employee> GetEmployees()
    {
        List<Employee> list = new();

        Employee employee = new Employee
        {
            Id = 1,
            FirstName = "Walid",
            LastName = "Hasen",
            AnnulSalary = 699464.3m,
            IsManager = true,
            DepartmentId = 1
        };
        list.Add(employee);
        employee = new Employee
        {
            Id = 2,
            FirstName = "Bonia",
            LastName = "Amain",
            AnnulSalary = 80000m,
            IsManager = true,
            DepartmentId = 2
        };
        list.Add(employee);
        employee = new Employee
        {
            Id = 3,
            FirstName = "Kamal",
            LastName = "Hossen",
            AnnulSalary = 343333m,
            IsManager = false,
            DepartmentId = 2
        };
        list.Add(employee);
        employee = new Employee
        {
            Id = 4,
            FirstName = "Jamal",
            LastName = "Hossen",
            AnnulSalary =20000.50m,
            IsManager = false,
            DepartmentId = 3
        };

        list.Add(employee);

        return list;
    }

    public static List<Department> GetDepartments()
    {
        var list = new List<Department>
        {
            new Department
            {
                Id=1,
                ShortName = "HR",
                LongName="Human Recourses"
            },
            new Department
            {
                Id=2,
                ShortName = "FN",
                LongName="Finance"
            },
            new Department
            {
                Id=3,
                ShortName = "TE",
                LongName="Technology"
            },
        };
        return list;
       
    }
}
