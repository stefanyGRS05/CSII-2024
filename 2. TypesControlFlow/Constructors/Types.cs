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
    // TODO: public Employee class constructor
    



    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
    public string FirstName { get; set; }

    //employee properties
    public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly ShiftStartTime { get; set; }
}

// public class Manager : Employee, IPerson
// {
//     public Manager(string firstName, string lastName) : base("desconocido", "desconocido")
//     {

//     }
// }

public struct Age
{
    public DateTime BirthDate { get; set; }
    public int YearsOld { get; set; }
}
