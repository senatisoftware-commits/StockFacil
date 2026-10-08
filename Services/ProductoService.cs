public class ProductoService
{
    public bool ValidarNombre(string nombre)
    {
        return !string.IsNullOrWhiteSpace(nombre);
    }

    public bool ValidarPrecio(decimal precio)
    {
        return precio > 0;
    }

    public bool ValidarProducto(Producto p)
    {
        return ValidarNombre(p.Nombre) && ValidarPrecio(p.Precio);
    }
}