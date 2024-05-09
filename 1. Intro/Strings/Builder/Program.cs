using System;
using System.Text; //needed for StringBuilder

// Documentacion: https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.replace?view=net-7.0

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = { "goats", "cats", "pigs" };

            // TODO: crear un StringBuilder
            StringBuilder sb = new StringBuilder("Texto inicial ", 200);


            // TODO: estadisticas del StringBuilder
            Console.WriteLine($"Capacidad: {sb.Capacity}");
            Console.WriteLine($"Longitud: {sb.Length}");

            // TODO: Append usando string builder
            sb.Append("Nuevo texto agreagado");
            sb.Append("Lista de animales: dogs, birds");


            // TODO: AppendLine agrega una linea
            sb.AppendLine();


            // TODO: AppendFormat se usa para formatear los strings
            sb.AppendFormat("Hay {0} animales que saltan", jumpCount);
            sb.AppendLine();

            // TODO: AppendJoin 
            sb.AppendJoin(" - ", animals);


            // TODO: Modificando contenido usando Replace
            sb.Replace("dogs", "monkeys");


            // TODO: Insertar contenido en un index especifico
            sb.Insert(0, "Texto insertado al inicio ");

            Console.WriteLine($"Capacidad: {sb.Capacity}");
            Console.WriteLine($"Longitud: {sb.Length}");


            // TODO: Convertir a un solo string
            string finalText = sb.ToString();
            Console.WriteLine(finalText);

        }
    }
}
