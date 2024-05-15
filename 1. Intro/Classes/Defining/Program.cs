using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Crear new object instances usando el "new" operator
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkien", 700);



            // TODO: Llamar un method en el object
            Console.WriteLine(book1.Desc());
            Console.WriteLine(book2.Desc());


            // TODO: setear una de las propiedades -- 
            // resultado error
            book1._title = "Harry Potter 2";


        }
    }
}
