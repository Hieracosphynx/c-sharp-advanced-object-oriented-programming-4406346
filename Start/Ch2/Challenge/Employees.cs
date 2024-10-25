// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge



using System.Net.Http.Headers;
using System.Runtime.InteropServices;


/**
* AdjustPay
* Required:
* ID
* Department
* Full Name
*/
public class Employee {
    public Employee() {}

    // YOUR CODE GOES HERE
    public virtual void AdjustPay(decimal dec) { }

    public required int ID {
        get;
        init;
    }

    public required string Department {
        get;
        set;
    }

    public required string FirstName {
        get;
        set;
    }

    public required string LastName {
        get;
        set;
    }

    public string FullName {
        get { return $"{FirstName} {LastName}"; }
    }

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

public class HourlyEmployee : Employee {
    public override void AdjustPay(decimal dec)
    {
        var product = PayRate * dec;
        PayRate += product;
    }

    public decimal PayRate {
        get;
        set;
    }
}

public class SalariedEmployee : Employee {
    public override void AdjustPay(decimal dec)
    {
        var product = Salary * dec;
        Salary += product;
    }

    public decimal Salary {
        get;
        set;
    }
}
