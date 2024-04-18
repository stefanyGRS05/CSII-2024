using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// documentation: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags <summary>
        /// XML Comments are used to help provide documentation    
        /// </summary>
        /// <param name="args">Ejemplo de arguments</param>
        /// <returns>Este es un ejemplo de un comentario XML</returns>
        static void Main(string[] args)
        {
            // Single line comments are created with double slashes
            // They are used to add notes to code
            // Pueden hacer los comentarios que quieran
            Console.WriteLine("Hello World!");

            /* Multi-line comments are created with a slash and asterisk
             *             * They are used to add longer notes to code
             */

        }
    }
}
