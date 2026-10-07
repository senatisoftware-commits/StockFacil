public class ProductoService { public bool ValidarProducto(Producto p) { return !string.IsNullOrWhiteSpace(p.Nombre) && p.Precio > 0; } } 
