using System;

// TODO: Functions pueden asignar valores a sus parametros
void imprimirConPrefix(string str="Texto", string str2 = "")
{
    Console.WriteLine($"{str} {str2}");
}

// TODO: Test con default parameters
imprimirConPrefix("Mundo"); // Hola Mundo


// TODO: Test con parametros individualizados
imprimirConPrefix(); // Hola Mundo


