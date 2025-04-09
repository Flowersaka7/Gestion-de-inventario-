public class Articulo
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public Articulo(string codigo, string nombre, decimal precio, int stock)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Código: {Codigo}, Nombre: {Nombre}, Precio: {Precio:C}, Stock: {Stock}");
    }
}



