using System;

namespace Inheritance
{
    // TODO: Declarar "Book" como subclass de Publication
    class Book : Publication
    {
        private string _author;

        // Usar base() keyword para inicializar el base class
        public Book(string name, string author, int pagecount, decimal price)
            :base(name, pagecount, price)
        {
            _author = author;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        // TODO: 'override' keyword usada para sobrepasar un base class method
        public override string GetPublicationInfo()
        {
            return $"Este libro {Name} fue escrito por {_author} y tiene {PageCount} paginas y cuesta {Price:C3}";
        }


    }
}