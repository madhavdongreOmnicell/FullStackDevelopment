### *Session 12*
# LINQ - Language-Integrated Query

Language-Integrated Query is a powerful query language introduced with .Net 3.5 & Visual Studio 2008. LINQ can be used with C# or Visual Basic to query different data sources.

It is uniform query syntax in C# to retrieve data from different sources and formats. It is integrated in C#, thereby eliminating the mismatch between programming languages and databases, as well as providing a single querying interface for different types of data sources.

For example, SQL is a Structured Query Language used to save and retrieve data from a database. In the same way, LINQ is a structured query syntax built in C# to retrieve data from different types of data sources such as `Collections`, `ADO.Net DataSet`, `XML Docs`, `Web service` and `MS SQL Server` and other databases.

![Alt](/images/linq/linq-usage.png)

Examples on using `Linq` on `Object Collection`:

Follow the below example

```C#
class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public char Gender { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }
}

class Project
{
    public int ProjectId { get; set; }
    public string PojectName { get; set; }
    public int TotalDuration { get; set; }
}

class EmployeeProject
{
    public int EmployeeId { get; set; }
    public int ProjectId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, FirstName = "Rajah", LastName = "Pruitt", Gender = 'M', Age = 28, IsActive = true },
            new Employee { EmployeeId = 2, FirstName = "Jane", LastName = "Trujillo", Gender = 'F', Age = 31, IsActive = true },
            new Employee { EmployeeId = 3, FirstName = "Grace", LastName = "Dejesus", Gender = 'F', Age = 36, IsActive = true },
            new Employee { EmployeeId = 4, FirstName = "Uriah", LastName = "Cole", Gender = 'M', Age = 26, IsActive = true },
            new Employee { EmployeeId = 5, FirstName = "Clare", LastName = "Melendez", Gender = 'M', Age = 41, IsActive = true },
            new Employee { EmployeeId = 6, FirstName = "Julian", LastName = "Byrd", Gender = 'F', Age = 38, IsActive = false },
            new Employee { EmployeeId = 7, FirstName = "Clark", LastName = "Conrad", Gender = 'M', Age = 53, IsActive = true },
            new Employee { EmployeeId = 8, FirstName = "Erich", LastName = "Booker", Gender = 'M', Age = 41, IsActive = true },
            new Employee { EmployeeId = 9, FirstName = "Minerva", LastName = "Walker", Gender = 'M', Age = 35, IsActive = false },
            new Employee { EmployeeId = 10, FirstName = "Leroy", LastName = "Blackwell", Gender = 'F', Age = 29, IsActive = true }
        };

        var projects = new List<Project>
        {
            new Project { ProjectId = 1, PojectName = "Company Citadel", TotalDuration = 381 },
            new Project { ProjectId = 2, PojectName = "Apollo Research", TotalDuration = 104 },
            new Project { ProjectId = 3, PojectName = "Earth Surface Temperature Visualization", TotalDuration = 538 },
            new Project { ProjectId = 4, PojectName = "Uber's pickup analysis", TotalDuration = 252 },
        };

        var employeeProjects = new List<EmployeeProject>
        {
            new EmployeeProject { EmployeeId = 1, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 2, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 3, ProjectId = 2 },
            new EmployeeProject { EmployeeId = 4, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 5, ProjectId = 3 },
            new EmployeeProject { EmployeeId = 6, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 7, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 8, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 9, ProjectId = 2 },
            new EmployeeProject { EmployeeId = 10, ProjectId = 3 },
            new EmployeeProject { EmployeeId = 6, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 3, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 1, ProjectId = 2 },
            new EmployeeProject { EmployeeId = 3, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 9, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 5, ProjectId = 2 },
            new EmployeeProject { EmployeeId = 3, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 8, ProjectId = 3 },
            new EmployeeProject { EmployeeId = 7, ProjectId = 3 }
        };

        // Without LINQ
        var femaleEmps = new List<Employee>();
        foreach (var employee in employees)
        {
            if (employee.Gender == 'F')
            {
                femaleEmps.Add(employee);
            }
        }

        // LINQ Way of doing it:
        var femaleEmployees = from employee in employees where employee.Gender == 'F' select employee;

        // The same can be written with Lambda expression

        var fEmployees = employees.Where(emp => emp.Gender == 'F');

        // find a inactive employees
        var inactiveEmployees = employees.Where(emp => emp.IsActive == false);

        // find specific employee named Julian Byrd
        var anEmployee = employees.Where(emp => emp.FirstName == "Julian" && emp.LastName == "Byrd").FirstOrDefault();

        // find first senior employee in the organization
        var seniorEmployee = employees.OrderByDescending(x => x.Age).FirstOrDefault();

        // or
        seniorEmployee = (from employee in employees orderby employee.Age descending select employee).FirstOrDefault();

        // find total duration of all project list
        var totalDuration = projects.Sum(x => x.TotalDuration);

        // join projects and employees
        var employeeWithProjects = (from project in projects
        join empproject in employeeProjects on project.ProjectId equals empproject.ProjectId
        join employee in employees on
        empproject.EmployeeId equals employee.EmployeeId
        select new
        {
            EmployeeName = employee.FirstName + " " + employee.LastName,
            employee.EmployeeId,
            project.ProjectId,
            project.PojectName
        }).ToList();


        // get all employees of a specific project
        var employeesByProject = (from project in projects
                    where project.PojectName == "Company Citadel"
                    join empproject in employeeProjects
                    on project.ProjectId equals empproject.ProjectId
                    join employee in employees on empproject.EmployeeId equals employee.EmployeeId
                    select new
                    {
                        employee.EmployeeId,
                        employee.FirstName,
                        employee.Gender
                    }).ToList();

        Console.ReadLine();

    }
}
```

> The above example also uses C# Lambda expression to build a LINQ query, the lambda expression is not only limited or a concept of LINQ query but it helps reducing the number of lines of code.

<br>

### C# Lambda Expression

Lambda expressions in C# are used like anonymous functions, with the difference that in Lambda expressions you don’t need to specify the type of the value that you input thus making it more flexible to use. 
The ‘=>’ is the lambda operator which is used in all lambda expressions. The Lambda expression is divided into two parts, the left side is the input and the right is the expression.

* Expression Lambda: Consists of the input and the expression.

    ```
    input => expression;
    ```
* Statement Lambda: Consists of the input and a set of statements to be executed.
    ```
    input => { statements };
    ```

    Example:

    ```C#
    List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};
    
    var square = numbers.Select(x => x * x); // <--- Lambda expression

    ```

## :white_check_mark: Tasks
:white_check_mark: Write LINQ query to find first Junior employee in the above example program.

:white_check_mark: Write LINQ query to find the minimum `TotalDuration` of the projects.

:white_check_mark: Write LINQ query to find all projects of a specific `EmployeeId`.