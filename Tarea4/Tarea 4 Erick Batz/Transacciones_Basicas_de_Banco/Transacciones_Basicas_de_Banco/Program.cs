using System;
using TransaccionesBancarias;


    class Programa
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de la clase CuentaBancaria
            CuentaBancaria cuenta = new CuentaBancaria("Erick", "Batz");
            Console.WriteLine($"Cuenta creada para {cuenta.PrimerNombre} {cuenta.Apellido} con balance inicial: {cuenta.Balance:C}");

            // Realizando algunas transacciones
            cuenta.Depositar(1000.00m);
            cuenta.Retirar(200.00m);
            cuenta.Depositar(300.00m);

            // Este retiro lanzará una excepción debido a fondos insuficientes
            try
            {
                cuenta.Retirar(100.00m);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Balance final: {cuenta.ObtenerBalanceActual():C}");
        }
}

