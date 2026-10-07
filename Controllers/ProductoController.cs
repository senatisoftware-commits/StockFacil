using System;
public class ProductoController {
    public static void Main(string[] args) {
        var servicio = new ProductoService();
        Console.WriteLine("=== PROBANDO SISTEMA STOCKFACIL ===");
        var prodValido = new Producto { Codigo = "P001", Nombre = "Memoria RAM", Precio = 250.50m, Stock = 10 };
        bool resultado1 = servicio.ValidarProducto(prodValido);
        Console.WriteLine($"Producto: {prodValido.Nombre} | Precio: S/.{prodValido.Precio} | ¨Es Valido?: {resultado1}");
        Console.WriteLine("-----------------------------------");
        var prodInvalido = new Producto { Codigo = "P002", Nombre = "Mouse Gamer", Precio = -15.00m, Stock = 5 };
        bool resultado2 = servicio.ValidarProducto(prodInvalido);
        Console.WriteLine($"Producto: {prodInvalido.Nombre} | Precio: S/.{prodInvalido.Precio} | ¨Es Valido?: {resultado2}");
        if (!resultado2) { Console.WriteLine("ALERTA: El sistema bloqueo el producto por precio invalido menor o igual a cero."); }
    }
}
