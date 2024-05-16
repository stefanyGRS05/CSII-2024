using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un nuevo Book object
            Book b1 = new Book("Libro 1", "Autor A", 825);
            Book b2 = new Book("Libro 2", "Autor B", 500);

            //Accedet a las propiedades
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);

            // TODO: Configurar ISBN y price
            b1.ISBN = "123456789";
            b1.Price = 19.99m;
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);

            // TODO: Cambiar el Name y PageCount
            b1.Name = "Libro 3";
            b1.PageCount = 1000;
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);



        }
    }
}
