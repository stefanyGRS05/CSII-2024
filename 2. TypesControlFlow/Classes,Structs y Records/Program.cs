namespace Galileo.Space;

//Una interfaz en programación es como un contrato entre diferentes partes de su código. 
//Imaginenlo como un acuerdo que especifica cómo deberían verse ciertas cosas o cómo deberían comportarse.
public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}

//Vamos a usar esa interface para definir esta clase como referencia de IPerson
//classes - reference types
public class Employee : IPerson
{
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
    public string FirstName { get; set; }

    // propiedades adicionales
    public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly ShiftStartTime { get; set; }
}


//Class Manager derivada de employee (solo 1 base class) 
//en adicion a la interface IPerson (0, una o mas)
public class Manager : Employee, IPerson
{
    public int NumberOfDirectReports { get; set; }
}

//Structs - es un Value Type, si tengo una referencia esta es hacia al objeto mismo
//Su comportamiento entra en juego cuando se usan variables y como estas se pasan desde y hacia metodos
public struct Age
{
    public DateTime BirthDate { get; set; }
    public int YearsOld { get; set; }
}

//Los Structs tambien pueden implementar Interfaces, asi que tambien pueden tener propiedades metodos igual a una clase
public struct VendorContact : IPerson
{
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
    public string FirstName { get; set; }
}

//Structs no pueden heredar (inherit) desde un base Struct
//public struct BiologicalAge : Age {}

//Records (C# 9)
//Son parecidos a las clases se comportan como clases pero se los utiliza donde quieran mantener
//escenarios con immutable objects, por ejemplo para pasarlos entre capas de la aplicacion
//primordialmente con el objetivo de crear objetos con un state y pasarlo
public record Customer : IPerson
{
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
    public string FirstName { get; set; }
}

//Records pueden tener inheritance
public record PremiereCustomer : Customer
{
    public byte CustomerLevel { get; init; }
}

//Record Structs (C# 10 .NET6)
//Se comporta como Value Type como un Struct
//Pero tambien tiene comportaminetos y habilidades de un Record
public record struct Order
{
    public int OrderId { get; set; }
    public DateOnly OrderDate { get; set; }

}
public record struct RecurringOrder
{

}
