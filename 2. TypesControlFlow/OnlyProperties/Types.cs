namespace Galileo.Space;

public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}

//classes - reference types
public class Employee : IPerson
{
    public Employee()
    {
        Id = 5;
    }

    public Employee(string firstName, string lastName,
        int empId = 0)
    {
        LastName = lastName;
        FirstName = firstName;
        EmployeeId = empId;
    }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
    public string FirstName { get; set; }

    //propiedades
    public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly ShiftStartTime { get; set; }
}

public class Manager : Employee, IPerson
{
    public Manager(string firstName, string lastName) : base(firstName, lastName)
    { }
    public int NumberOfDirectReports { get; set; }
}

//structs - value types
public struct Age
{
    public Age(DateTime dob, int years)
    {
        BirthDate = dob;
        YearsOld = years;
    }
    public DateTime BirthDate { get; set; }
    public int YearsOld { get; set; }
}

public struct VendorContact : IPerson
{
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
    public string FirstName { get; set; }
}

//records (C# 9)
public record Customer : IPerson
{
    public Customer()
    { }
    public Customer(string firstName)
    {
        FirstName = firstName;
    }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
    public string FirstName { get; set; }
}

public record PremiereCustomer : Customer
{
    public PremiereCustomer()
    { }
    public PremiereCustomer(byte level)
    {
        CustomerLevel = level;
    }
    public byte CustomerLevel { get; init; } //Esto puede ser Seteado o asignarle un valor luego de ser inicializado
}

public record struct Order
{
    public int OrderId { get; set; }
    public DateOnly OrderDate { get; set; }

}
public record struct RecurringOrder
{

}
