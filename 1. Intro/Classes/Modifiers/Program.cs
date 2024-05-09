using System;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear una instancia de Book
            Book b1 = new Book("Titulo de Libro", "Nombre Autor", 825);

            // 
            // b1._name = "Cat in the Hat";
            Console.WriteLine(b1.GetDescription());

            // TODO: acceder a campos usando functions en lugar de directamente 
            b1.SetName("Libro 2");
            b1.SetAuthor("Autor 2");
            b1.SetPagecount(1000);

            Console.WriteLine(b1.GetDescription());

        }
    }
}
