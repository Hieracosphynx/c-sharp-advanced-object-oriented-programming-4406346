// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee {
    private static int _employeeCount = 0;
    private static int IDStart;
    static Employee(){
        IDStart = 1000;
    }
    public Employee() {
        Employee._employeeCount++;
        ID = Employee.IDStart++;
    }

    public int ID {get; set;}
    public static int EmployeeCount { get => _employeeCount; }
    public required string Department {get; set;}
    public required string FullName {get; set;}

    public virtual void AdjustPay(decimal percentage) {}

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

public class HourlyEmployee : Employee {
    public HourlyEmployee() {}

    public decimal PayRate {get; set;}

    public override void AdjustPay(decimal percentage)
    {
        PayRate += (PayRate * percentage);
    }
}

public class SalariedEmployee : Employee {
    public SalariedEmployee() {}

    public decimal Salary {get; set;}

    public override void AdjustPay(decimal percentage) {
        Salary += (Salary * percentage);
    }
}
