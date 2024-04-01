using System;

class MainClass
{
    static void Main(string[] args)
    {
        // Creación de objetos Customer
        Customer cliente1 = new Customer("Juan", "Pérez", "12345678A");
        Customer cliente2 = new Customer("María", "González", "87654321B");
        Customer cliente3 = new Customer("Pedro", "Sánchez", "98765432C");

        // Impresión de los datos de los clientes
        Console.WriteLine("Datos de los clientes:");
        Console.WriteLine($"Cliente 1: Nombre - {cliente1.Nombre}, Apellido - {cliente1.Apellido}, DNI - {cliente1.Dni}");
        Console.WriteLine($"Cliente 2: Nombre - {cliente2.Nombre}, Apellido - {cliente2.Apellido}, DNI - {cliente2.Dni}");
        Console.WriteLine($"Cliente 3: Nombre - {cliente3.Nombre}, Apellido - {cliente3.Apellido}, DNI - {cliente3.Dni}");
    }
}
