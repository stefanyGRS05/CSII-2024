using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var cuentas = new List<CuentaBancaria>();

        while (true)
        {
            Console.WriteLine("1. Crear nueva cuenta");
            Console.WriteLine("2. Realizar depósito");
            Console.WriteLine("3. Realizar retiro");
            Console.WriteLine("4. Ver saldo");
            Console.WriteLine("5. Salir");
            Console.Write("Ingresa el número de una opción: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("\nNombre y apellido del titular: ");
                    var nombre = Console.ReadLine();
                    var cuenta = new CuentaBancaria(nombre);
                    cuentas.Add(cuenta);
                    Console.WriteLine($"Se creó la cuenta número {cuenta.NumeroCuenta}, a nombre de {nombre}.\n");
                    break;
                case "2":
                    RealizarTransaccion(cuentas, true);
                    break;
                case "3":
                    RealizarTransaccion(cuentas, false);
                    break;
                case "4":
                    Console.Write("\nNúmero de cuenta: ");
                    var numeroCuenta = int.Parse(Console.ReadLine());
                    var cuentaSeleccionada = cuentas.Find(c => c.NumeroCuenta == numeroCuenta);
                    if (cuentaSeleccionada != null)
                    {
                        Console.WriteLine($"El saldo de esta cuenta, a nombre de {cuentaSeleccionada.Titular}, es de: ${cuentaSeleccionada.Saldo:C}\n");
                    }
                    else
                    {
                        Console.WriteLine("Cuenta no encontrada.\n");
                    }
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Inténtalo nuevamente.\n");
                    break;
            }
        }
    }

    static void RealizarTransaccion(List<CuentaBancaria> cuentas, bool esDeposito)
    {
        Console.Write("\nNúmero de cuenta: ");
        var numeroCuenta = int.Parse(Console.ReadLine());
        var cuentaSeleccionada = cuentas.Find(c => c.NumeroCuenta == numeroCuenta);
        if (cuentaSeleccionada != null)
        {
            Console.Write("Monto: $");
            var monto = decimal.Parse(Console.ReadLine());
            if (esDeposito)
            {
                cuentaSeleccionada.Depositar(monto);
                Console.WriteLine($"Depósito realizado. El nuevo saldo es de: ${cuentaSeleccionada.Saldo:C}\n");
            }
            else
            {
                cuentaSeleccionada.Retirar(monto);
                Console.WriteLine($"Retiro realizado. El nuevo saldo es de: ${cuentaSeleccionada.Saldo:C}\n");
            }
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.\n");
        }
    }
}

class CuentaBancaria
{
    private static int _siguienteNumeroCuenta = 1;

    public int NumeroCuenta { get; }
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public CuentaBancaria(string titular)
    {
        NumeroCuenta = _siguienteNumeroCuenta++;
        Titular = titular;
        Saldo = 0.0m;
    }

    public void Depositar(decimal monto)
    {
        Saldo += monto;
    }

    public void Retirar(decimal monto)
    {
        if (monto <= Saldo)
        {
            Saldo -= monto;
        }
        else
        {
            Console.WriteLine("El saldo es insuficiente para realizar esta transacción.\n");
        }
    }
}
