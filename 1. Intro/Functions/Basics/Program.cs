using System;

// Demostracion de funciones

// TODO: Functions con return type, name, y parametros opcionales
float millasAKilometros(float millas)
{
    float result = millas * 1.60934f;
    return result;
}


// TODO: Function sin return value - es tipo 'void'
void imprimirPrefix(string str)
{
    Console.WriteLine($">> {str}");
}



// TODO: Exec funct 1
Console.WriteLine($"Conversion: {millasAKilometros(2.3f)}"); // 16.0934



// TODO: Exec funct 2
imprimirPrefix("Hola Mundo"); // >> Hola Mundo
imprimirPrefix("Test string"); // >> Hello World


