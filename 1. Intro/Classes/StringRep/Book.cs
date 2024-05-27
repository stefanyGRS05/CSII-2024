using System;

namespace StringRep
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; }

        public Book(string name, string author, int pages)
        {
            Name = name;
            Author = author;
            PageCount = pages;
        }

        // TODO: el metodo ToString genera una represenacion de string object
        public override string ToString()
        {
            return $"Book: {Name} by {Author}, {PageCount} pages";
        }


        // TODO: ToString puede ser overloaded para producir diferentes tipos de formatos
        public string ToString(char format)
        {
            if (format == 'A')
            {
                return $"Book: {Name} by {Author}";
            }
            else if (format == 'B')
            {
                return $"Formato B: {Name} by {Author}, {PageCount} pages";
            }
            else
            {
                return ToString();
            }
        }


    }
}