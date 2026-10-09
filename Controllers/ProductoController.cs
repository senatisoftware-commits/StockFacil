using System;

public class ProductoController
{
public static void Main(string[] args)
{
var servicio = new ProductoService();

    Console.WriteLine("=== PROBANDO SISTEMA STOCKFACIL ===");

    // Prueba 1: Producto válido
    var prodValido = new Producto
    {
        Codigo = "P001",
        Nombre = "Memoria RAM",
        Precio = 250.50m,
        Stock = 10
    };

    bool resultado1 = servicio.ValidarProducto(prodValido);

    Console.WriteLine($"Producto: {prodValido.Nombre} | Precio: S/.{prodValido.Precio} | Es valido?: {resultado1}");

    Console.WriteLine("-----------------------------------");

    // Prueba 2: Producto con precio inválido
    var prodInvalido = new Producto
    {
        Codigo = "P002",
        Nombre = "Mouse Gamer",
        Precio = -15.00m,
        Stock = 5
    };

    bool resultado2 = servicio.ValidarProducto(prodInvalido);

    Console.WriteLine($"Producto: {prodInvalido.Nombre} | Precio: S/.{prodInvalido.Precio} | Es valido?: {resultado2}");

    if (!resultado2)
    {
        Console.WriteLine("ALERTA: El sistema bloqueo el producto por precio invalido menor o igual a cero.");
    }

    Console.WriteLine("-----------------------------------");

    // Prueba 3: Producto sin nombre
    var prodSinNombre = new Producto
    {
        Codigo = "P003",
        Nombre = "",
        Precio = 100.00m,
        Stock = 3
    };

    bool resultado3 = servicio.ValidarProducto(prodSinNombre);

    Console.WriteLine($"Producto sin nombre | Es valido?: {resultado3}");

    if (!resultado3)
    {
        Console.WriteLine("PRUEBA CORRECTA: El sistema rechazo el producto porque no tiene nombre.");
    }
}
}
