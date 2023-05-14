// See https://aka.ms/new-console-template for more information
using TCPData;
using TCPExtension;



#region Initial LInQ Tutorial
//List<Employee> employeeList = Data.GetEmployees();
//List<Department> departmentList = Data.GetDepartments();
//var filteredEmployees=employeeList.Filter(x=>x.IsManager==false);

//var totalEmpSalary = filteredEmployees.Sum(x => x.AnnulSalary);
//foreach (var item in filteredEmployees)
//{
//    Console.WriteLine($"First Name: {item.FirstName}");
//    Console.WriteLine($"Last Name: {item.LastName}");
//    Console.WriteLine($"Annul Salary: {item.AnnulSalary}");
//    Console.WriteLine($"IsManager: {item.IsManager}");

//    Console.WriteLine("------------------");
//}
//Console.WriteLine($"Total Employee Salary: {totalEmpSalary}");

//var resultLIst = from emp in employeeList
//                 join dep in departmentList 
//                 on emp.DepartmentId equals dep.Id
//                 select new
//                 {
//                     FirstName = emp.FirstName,
//                     LastName = emp.LastName,
//                     AnnualSalary = emp.AnnulSalary,
//                     IsManager = emp.IsManager,
//                     Department = dep.LongName
//                 };

//foreach (var item in resultLIst)
//{
//    Console.WriteLine($"First Name: {item.FirstName}");
//    Console.WriteLine($"Last Name: {item.LastName}");
//    Console.WriteLine($"Annul Salary: {item.AnnualSalary}");
//    Console.WriteLine($"IsManager: {item.IsManager}");
//    Console.WriteLine($"Department: {item.Department}");

//    Console.WriteLine("------------------");
//}

//var avarageAnnuulSalary = resultLIst.Average(x => x.AnnualSalary);
//var sumAnnuulSalary = resultLIst.Sum(x => x.AnnualSalary);
//var maxAnnuulSalary = resultLIst.Max(x => x.AnnualSalary);
//var minAnnuulSalary = resultLIst.Min(x => x.AnnualSalary);

//Console.WriteLine($"Avarage Annuul Salary: {avarageAnnuulSalary}");
//Console.WriteLine($"Total Annuul Salary: {sumAnnuulSalary}");
//Console.WriteLine($"Minimum Annuul Salary: {minAnnuulSalary}");
//Console.WriteLine($"Maximum Annuul Salary: {maxAnnuulSalary}");
#endregion

#region LINQExamples_1


List<Employee> employeeList = Data.GetEmployees();
List<Department> departmentList = Data.GetDepartments();

//Select and Where Operator Method Syntex//

//var results = employeeList.Select(e => new
//{
//    FullName = e.FirstName + " " + e.LastName,
//    AnnulSalary = e.AnnulSalary
//}).Where(e=>e.AnnulSalary>=50000);


//foreach(var employee in results)
//{
//    Console.WriteLine($"{employee.FullName} {employee.AnnulSalary}");
//}


//Select and Where Operator Query Systex//

//var result = from emp in employeeList
//             where emp.AnnulSalary <= 50000
//             select new
//             {
//                 FullName = emp.FirstName + " " + emp.LastName,
//                 AnnulSalary = emp.AnnulSalary
//             };
//foreach (var employee in result)
//{
//    Console.WriteLine($"{employee.FullName} {employee.AnnulSalary}");
//}

//Join Operation Example -Method Syntex//

//var reslults = departmentList.Join(employeeList,
//    department => department.Id,
//    employee => employee.DepartmentId,
//    (department, employee) => new
//    {
//        FullName = employee.FirstName + " " + employee.LastName,
//        AnnualSalary = employee.AnnulSalary,
//        departmentName = department.LongName

//    });
//foreach (var item in reslults)
//{
//    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10} \t {item.departmentName}");
//}

//Join Operation Example -Query Syntex//

//var reslults = from dep in departmentList
//               join emp in employeeList
//               on dep.Id equals emp.DepartmentId
//               select new
//               {
//                   FullName = emp.FirstName + " " + emp.LastName,
//                   AnnualSalary = emp.AnnulSalary,
//                   departmentName = dep.LongName

//               };
//foreach (var item in reslults)
//{
//    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10} \t {item.departmentName}");
//}


//Group Join Operation Example -Method Syntex//

//var result = departmentList.GroupJoin(employeeList,
//    dep => dep.Id,
//    emp => emp.DepartmentId,
//    (dep, employeesGroup) => new
//    {
//        Employees = employeesGroup,
//        DepartmentName = dep.LongName
//    });
//foreach (var item in result)
//{
//    Console.WriteLine($"Department Name: {item.DepartmentName}");
//    foreach (var employee in item.Employees)
//    {
//        Console.WriteLine($"Employee Name: {employee.FirstName + " " + employee.LastName}");
//    }
//}


#endregion





