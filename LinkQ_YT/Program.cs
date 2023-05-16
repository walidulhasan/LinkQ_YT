// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using TCPData;
using TCPExtension;
List<Employee> employeeList = Data.GetEmployees();
List<Department> departmentList = Data.GetDepartments();


#region Initial LInQ Tutorial

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

//Group Join Operation Example -Query Syntex//

//var results = from dep in departmentList
//              join emp in employeeList
//              on dep.Id equals emp.DepartmentId into employeeGroup
//              select new
//              {
//                  Employees = employeeGroup,
//                  DepartmentName = dep.LongName
//              };
//foreach (var item in results)
//{
//    Console.WriteLine($"Department Name: {item.DepartmentName}");
//    foreach (var employee in item.Employees)
//    {
//        Console.WriteLine($"Employee Name: {employee.FirstName + " " + employee.LastName}");
//    }
//}


#endregion


#region LInQExamples_2

#region Working List
//Sorting Operators
//OrderBy
//ThenBy
//ThenByDescending

//Grouping Operators
//GroupBy
//ToLookup

//Quantifier Operators
//All
//Any
//Contains

//Filter Operators
//OfType
//Where

//Element Operators

//ElementAt
//ElementAtOrDefault
//First
//FirstOrDefault
//Last
//LastOrDefault
//Single
//SingleOrDefault
#endregion

#region Sorting Operators
//Sorting Operators using Method Syntex//

//var results = employeeList.Join(departmentList, e => e.DepartmentId, d => d.Id,
//(emp, dep) => new
//{
//    Id = emp.Id,
//    FirstName = emp.FirstName,
//    LastName = emp.LastName,
//    AnnualSalary = emp.AnnulSalary,
//    DepartmentId = emp.DepartmentId,
//    DepartmentName = dep.LongName
//}).OrderByDescending(x => x.DepartmentName).ThenByDescending(x=>x.AnnualSalary);

//foreach (var item in results)
//{
//    Console.WriteLine($"First Name: {item.FirstName,-10} Last Name: {item.LastName,-10} Annul Salary: {item.AnnualSalary,-10} Department Name: {item.DepartmentName,-10}");
//}


//var results = from emp in employeeList
//              join dep in departmentList
//              on emp.DepartmentId equals dep.Id
//              orderby dep.LongName, emp.AnnulSalary ascending
//              select new
//              {
//                  Id = emp.Id,
//                  FirstName = emp.FirstName,
//                  LastName = emp.LastName,
//                  AnnualSalary = emp.AnnulSalary,
//                  DepartmentId = emp.DepartmentId,
//                  DepartmentName = dep.LongName
//              };
//foreach (var item in results)
//{
//    Console.WriteLine($"First Name: {item.FirstName,-10} Last Name: {item.LastName,-10} Annul Salary: {item.AnnualSalary,-10} Department Name: {item.DepartmentName,-10}");
//}
#endregion

#region Grouping Operators

//GroupBy using Method Syntex//

//var groupResult = employeeList.GroupBy(x=>x.DepartmentId);
//foreach (var item in groupResult)
//{
//    foreach (var item1 in item)
//    {
//        Console.WriteLine($"Employee Name: {item1.FirstName+" "+item1.LastName,-10} DepartmentId: {item1.DepartmentId}");
//    }
//}

//var groupResult = employeeList.OrderBy(x=>x.DepartmentId).ToLookup(x => x.DepartmentId);
//foreach (var item in groupResult)
//{
//    foreach (var item1 in item)
//    {
//        Console.WriteLine($"Employee Name: {item1.FirstName + " " + item1.LastName,-10} DepartmentId: {item1.DepartmentId}");
//    }
//}

//GroupBy using Query Syntex

//var resultG = from emp in employeeList
//              orderby emp.DepartmentId ascending
//              group emp by emp.DepartmentId;
//foreach (var item in resultG)
//{
//    Console.WriteLine(item.Key);
//    foreach (var item1 in item)
//    {
//        Console.WriteLine($"Employee Name: {item1.FirstName + " " + item1.LastName,-10} DepartmentId: {item1.DepartmentId}");
//    }
//}

#endregion

#region Quantifier Operators


//var annualSalaryCompare = 200;
//var searchEmployee = new Employee
//{
//    Id = 3,
//    FirstName = "Kamal",
//    LastName = "Hossens",
//    AnnulSalary = 343333m,
//    IsManager = false,
//    DepartmentId = 2
//};

//bool isTrueAll = employeeList.All(e => e.AnnulSalary > annualSalaryCompare);

//if (isTrueAll)
//{
//    Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
//}
//else
//{
//    Console.WriteLine($"Not all employee annual salaries are above {annualSalaryCompare}");
//}
//bool isTrueAny = employeeList.Any(e => e.AnnulSalary > annualSalaryCompare);
//if (isTrueAny)
//{
//    Console.WriteLine($"At employee annual salaries are above {annualSalaryCompare}");
//}
//else
//{
//    Console.WriteLine($"Not At employee annual salaries are above {annualSalaryCompare}");
//}

//bool containsEmployee = employeeList.Contains(searchEmployee,new EmployeeComparer());
//Console.WriteLine(containsEmployee);

//public class EmployeeComparer : IEqualityComparer<Employee>
//{
//    public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
//    {
//        if (x.Id==y.Id && x.FirstName.ToLower()==y.FirstName.ToLower() && x.LastName.ToLower()==y.LastName.ToLower())
//        {
//            return true;
//        }
//        return false;
//    }

//    public int GetHashCode([DisallowNull] Employee obj)
//    {
//        return obj.Id.GetHashCode();
//    }
//}
#endregion

#region Filter Operators
//OfType filter Operator
//static ArrayList GetHetrogeneousDataCollection()
//{
//    ArrayList arrayList = new ArrayList();
//    arrayList.Add(100);
//    arrayList.Add("Bob Jones");
//    arrayList.Add(2000);
//    arrayList.Add(3000);
//    arrayList.Add("Bill Henderson");
//    arrayList.Add(new Employee { Id = 6, FirstName = "Jennifer", LastName = "Dale", AnnulSalary = 90000, IsManager = true, DepartmentId = 1 });
//    arrayList.Add(new Employee { Id = 7, FirstName = "Dane", LastName = "Hughes", AnnulSalary = 60000, IsManager = false, DepartmentId = 2 });
//    arrayList.Add(new Department { Id = 7, ShortName = "MKT", LongName = "Marketing" });
//    arrayList.Add(new Department { Id = 8, ShortName = "R&D", LongName = "Research and Development" });
//    arrayList.Add(new Department { Id = 9, ShortName = "PRD", LongName = "Production" });
//    return arrayList;
//}

//ArrayList mixedCollection = GetHetrogeneousDataCollection();
//var stringResult = from s in mixedCollection.OfType<string>()
//                   select s;

//foreach (var item in stringResult)
//    Console.WriteLine(item);

//Where//

//var result=employeeList.Where(x=>x.AnnulSalary<20000).ToList();
//foreach (var item in result)
//    Console.WriteLine(item.AnnulSalary);


#endregion

#region Element Operators
//ElementAt//

//var emp=employeeList.ElementAt(0);
//Console.WriteLine(emp.Id);

//ElementAtOrDefault ElementAt Operators//

//var emp1 = employeeList.ElementAtOrDefault(14);
//if (emp1 != null)
//{
//    Console.WriteLine(emp1.Id);
//}
//else
//{
//    Console.WriteLine("This employee record does not exist within the collection");
//}


//First, FirstOrDefault, Last, LastOrDefault,Single SingleOrDefault Operators

//List<int> integerList=new List<int> { 1, 13, 24, 17, 28 };
//List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
//int result=integerList.First(i=>i%2==0);
//int result1 = integerList.FirstOrDefault();
//int result2 = integerList.Last();
//int result3 = integerList.LastOrDefault();
//int result4 = integerList.Single(x => x == 13);
//string? result5 = names.SingleOrDefault(x =>x.StartsWith("B"));
//Console.WriteLine($"First: {result,-10} FirstOrDefault: {result1,-10} Last: {result2,-10} LastOrDefault: {result3,-10} Single: {result4,-10} SingleOrDefault: {result5,-10}");





#endregion

#endregion

#region LInQExamples_3
#region Working List
//Equality Operator
//SequenceEqual

//Concatenation Operator
//Concat

//Set Operators
//Distinct, Except, Intersect and Union

//Generiation OPerators
//DefaultiEmpty, Empty, Range and Repeat

//Aggregate Operators
//Aggregate, Average, Count, Sum And Max

//Partitioning OPerators
//Skip, SkipWhile, Take and TakeWhile

//Conversion Operators
//ToLIst, ToDicitionary and ToArray

//Projection Operators
//Select and SelectMany

//Keywords
//Let
//Into

#endregion

#region Equality Operator
//SequenceEqual
//var integerListLeft=new List<int> {1,2,3,4,5,6,7,8,9};
//var integerListRight = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//var boolSequenceEqual = integerListLeft.SequenceEqual(integerListRight);
//Console.WriteLine(boolSequenceEqual);
#endregion

#region Concatenation Operator

//Concat
//var integerListLeft=new List<int> {1,2,3,4,5,6,7,8,9};
//var integerListRight = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//IEnumerable<int> integerLIstConcat=integerListLeft.Concat(integerListRight);
//foreach(var integer in integerLIstConcat)
//    Console.WriteLine(integer);



#endregion

#region Aggregate Operators
//Aggregate,Average,Count,Sum,Max

//decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0, (totalAnnualSalary, e) =>
//{
//    var bonus = (e.IsManager) ? 0.04m : 0.02m;
//    totalAnnualSalary = (e.AnnulSalary + e.AnnulSalary * bonus) + totalAnnualSalary;
//    return totalAnnualSalary;
//});

//Console.WriteLine($"Total Annual Salary of all employees (including bonus): {totalAnnualSalary}");

//string data = employeeList.Aggregate<Employee, string>("Employee Annual Salaries (including Bonus):",
//    (s, e) =>{
//        var bonus = (e.IsManager) ? 0.04m : 0.02m;
//        s += $"{e.FirstName,-10} {e.LastName,-10} - {e.AnnulSalary + (e.AnnulSalary * bonus)}\n\n\n";
//        return s;
//    });
//Console.WriteLine(data);

//Average//

//decimal average = employeeList.Average(x => x.AnnulSalary);
//decimal max = employeeList.Max(x => x.AnnulSalary);
//decimal min = employeeList.Min(x => x.AnnulSalary);
//decimal sum = employeeList.Sum(x => x.AnnulSalary);
//int count = employeeList.Count();

//Console.WriteLine($"\nMax Salary: {max}\nMin Salary:{min}\nAverage Salary:{average}\nTotal Salary:{sum}\nCount:{count}");

#endregion

#region Generiation OPerators (DefaultiEmpty, Empty, Range and Repeat)

//DefaultiEmpty//

//List<Employee> employees = new List<Employee> { new Employee { Id=1} };
//var newList = employees.DefaultIfEmpty();
//var result = newList.ElementAt(0);
//if (result?.Id>0)
//{
//    Console.WriteLine($"Result:{result.Id}");
//}
//else
//{
//    Console.WriteLine("Result is Empty");
//}

//Empty//

//List<Employee> emptyEmployeeList=Enumerable.Empty<Employee>().ToList();
//employeeList.Add(new Employee { Id=10,FirstName="Korim",LastName="Miya"});
//foreach(var employee in employeeList)
//{
//    Console.WriteLine(employee.FirstName);
//}

//Range//
//var intCollection = Enumerable.Range(1, 100);
//foreach (var number in intCollection)
//{
//    Console.WriteLine(number);
//}

//Repeat//
//var strCollection = Enumerable.Repeat<string>("Placeholder",10000);
//foreach (var repeter in strCollection)
//{
//    Console.WriteLine(repeter);
//}




#endregion

#region Set Operators (Distinct, Except, Intersect and Union)

//Distinct//

//var intList=new List<int>{1,2,3,4,4,5,5,5,4,56,4,};
//var distinctIntList=intList.Distinct();
//foreach (var item in distinctIntList)
//{
//    Console.WriteLine(item);
//}

//The Except() method requires two collections. It returns a new collection with elements from the first collection which do not exist in the second collection (parameter collection).//

//IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4,10,12,16,5,6};
//IEnumerable<int> collection2 = new List<int> { 1,2,5,6 };
//var result=collection1.Except(collection2).ToList();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//The Intersect()  method requires two collections. It returns a new collection with elements from the first collection which do exist in the second collection (parameter collection).//

//IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4, 10, 12, 16, 5, 6,7 };
//IEnumerable<int> collection2 = new List<int> { 1, 2, 5, 6,7 };
//var result = collection1.Intersect(collection2).ToList();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//Union//
//IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4, 10, 12, 16, 5, 6, 7 };
//IEnumerable<int> collection2 = new List<int> { 1, 2, 5, 6,7 };
//var result = collection1.Union(collection2).ToList();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


#endregion

#region Partitioning OPerators (Skip, SkipWhile,SkipLast Take and )
//Skip//
//var result = employeeList.Skip(3);
//foreach (var employee in result)
//    Console.WriteLine(employee.Id+" "+employee.FirstName+" "+employee.LastName);

//SkipWhile//
//var result = employeeList.SkipWhile(x=>x.Id==1);
//foreach (var employee in result)
//   Console.WriteLine(employee.Id+" "+employee.FirstName+" "+employee.LastName);

//Take//
//var result = employeeList.Take(10);
//foreach (var employee in result)
//    Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);

//TakeWhile//
//var result = employeeList.TakeWhile(x=>x.AnnulSalary>200000);
//foreach (var employee in result)
//    Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);

#endregion

#region Conversion Operators (ToLIst, ToDicitionary and ToArray)

//ToLIst//
//var datas = employeeList.Where(x => x.AnnulSalary > 20000).ToList();
//var data = (from employee in employeeList
//           where employee.AnnulSalary > 200000
//           select employee).ToList();

//foreach (var item in datas)
//{
//    Console.WriteLine(item.FirstName);
//}


//Dictionary<int,Employee> dictionary = (from emp in employeeList
//                                      where emp.AnnulSalary>40000
//                                      select emp).ToDictionary<Employee,int>(x=>x.Id);
//foreach (var item in dictionary.Keys)
//{
//    Console.WriteLine(dictionary[item].FirstName);
//}

//ToArray//

//var datas = employeeList.Where(x => x.AnnulSalary > 20000).ToArray();
//var data = (from employee in employeeList
//            where employee.AnnulSalary > 200000
//            select employee).ToArray();

//foreach (var item in datas)
//{
//    Console.WriteLine(item.FirstName);
//}
#endregion

#region Let Clause and Into Clause
//Let//
//---------//
//Into//
//var results = from emp in employeeList
//              where emp.AnnulSalary > 50000
//              select emp
//              into HighEarners
//              where HighEarners.IsManager==true
//              select HighEarners;
//foreach (var items in results)
//    Console.WriteLine($"{items.Id,-5} {items.FirstName,-10} {items.LastName,-10} {items.AnnulSalary,-10}");

#endregion

#region Projection Operators - Select,SelectMany
//Select//

//var datas = employeeList.Select(d => d.FirstName);
//foreach (var items in datas)
//{
//    Console.WriteLine(items);
//}

//SelectMany//

var datas = employeeList.SelectMany(d => d.FirstName);
foreach (var items in datas)
{
    Console.WriteLine(items);
}
#endregion

#endregion


