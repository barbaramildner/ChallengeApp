using ChallengeApp;

Employee employee1 = new Employee ("Maria", "Kowalska", 45);
Employee employee2 = new Employee ("Katarzyna", "Nowak", 33);
Employee employee3 = new Employee("Tadeusz", "Kot", 40);

employee1.AddScore(6);
employee1.AddScore(4);
employee1.AddScore(2);
employee1.AddScore(4);
employee1.AddScore(1);

employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(4);
employee2.AddScore(3);
employee2.AddScore(8);

employee3.AddScore(4);
employee3.AddScore(4);
employee3.AddScore(7);
employee3.AddScore(0);
employee3.AddScore(3);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null; 

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
  }
Console.WriteLine("Name:" + employeeWithMaxResult.Name);
Console.WriteLine("Surname:" + employeeWithMaxResult.Surname);
Console.WriteLine("Age:" + employeeWithMaxResult.Age);
Console.WriteLine("Score:" + employeeWithMaxResult.Result);
