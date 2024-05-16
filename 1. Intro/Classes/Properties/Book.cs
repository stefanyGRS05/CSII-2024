using System;
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

namespace Properties
{
    // classes tienen nobres unicos dentro de los namespace
    class Book
    {
        // classes con variables de instancia
        private string _name;
        private string _author;
        private int _pagecount;

        // classes con uno o mas constructores
        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        // TODO: usar Properties para implementar acceso a datos internos

        public string Name
        {
            get { 
                return _name; 
            }
            set { 
                _name = value; 
            }
        }


        // TODO: Forma abreviada de escribirlos utilizando el operador => (= >)
        // para crear propiedades "expression-bodied" 

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int PageCount
        {
            get => _pagecount;
            set => _pagecount = value;
        }

        //TODO: crear Computed Property para Description

        public string Description
        {
            get => $"{Name} by {Author}, {PageCount}";
        }

        //Propiedades Autogeneradas (Opcional): no tienen backing fields en el class, sirven como place-holders de Datos
        public string ISBN { get; set; }

        public decimal Price { get; set; }
    }
}
