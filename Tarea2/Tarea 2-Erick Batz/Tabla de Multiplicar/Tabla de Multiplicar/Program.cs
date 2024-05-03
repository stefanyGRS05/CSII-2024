using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_Multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numUsuario; //creacion de variable
            
            
            //pedida de imput
           
            Console.WriteLine("Ingrese un numero del 1 al 10 para generar la tabla de multiplicar");
            
            //Controlando la excepcio para que no sea mayor a 10 y menor a 1

            try
            {
                numUsuario = int.Parse(Console.ReadLine());

                if (numUsuario < 1 || numUsuario > 10)
                {
                    throw new ArgumentOutOfRangeException("numUsuario", "El número debe estar entre 1 y 10.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("No ingresaste un número válido.");
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


            Console.WriteLine($"la tabla de multiplicar que crearemos sera del : {numUsuario}");


            
            //Creacion del blucle for para creacion de las tablas 
            
            for(int i = 0; i<=10; i++)
            {
                Console.WriteLine($" {numUsuario} * {i} = {i*numUsuario}");
            }
        }
    }
}
