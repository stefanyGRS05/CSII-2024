
namespace TablaMultiplicarWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, numero, result;

            Console.WriteLine("\n\tTarea2");
            Console.WriteLine("Porfavor ingrese un numero del 1 al 10: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("\nTABLA DE MULTIPLICAR DEL {0} \n\n", numero);
            while (i <= 10)
            {

                result = i * numero;
                Console.WriteLine(i + " X " + numero + " = " + result);
                i++;
            }
            Console.Write("\n\tQue tenga buen dia, Presione <<ENTER>> para finalizar . . . :')");
            Console.ReadKey();
        }
    }
}

