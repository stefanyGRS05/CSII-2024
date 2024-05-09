using System;

namespace RefAndOutParams
{
    class Program
    {
        // TODO: El valor de los argumentos no puede ser modificado por la funcion
        // porque estos son una copia del valor original


        // TODO: Argumentos pasados como reference pueden ser modificados
        // por la funcion y executados



        // TODO: El "out" keyword significa que el parametro regresa un valor
        // usado para suplir de data a la misma funcion


        static void Main(string[] args)
        {
            int val1 = 8;
            int val2 = 20;

            // Function no modifican argumentos normalmente


            // TODO: Usando el "ref" keyword, argumentos pueden ser pasados por referencia
            // lo que permite a la funcion modificarlos



            // TODO: El "out" keyword puede ser usado para indicar que un argumento
            // regresa un valor y no que es un input



        }
    }
}
