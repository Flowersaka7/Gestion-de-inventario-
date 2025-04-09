using System;
using System.Collections.Generic;

public class Inventario
{
    private List<Articulo> articulos = new List<Articulo>();

    public void AgregarArticulo(Articulo nuevo)
    {
        if (articulos.Count < 50)
            articulos.Add(nuevo);
        else
            Console.WriteLine("❌ Inventario lleno (máximo 50 artículos).");
    }

    public void MostrarInventario()
    {
        if (articulos.Count == 0)
        {
            Console.WriteLine("📦 Inventario vacío.");
            return;
        }

        Console.WriteLine("\n📋 Artículos en inventario:");
        foreach (var art in articulos)
            art.MostrarInfo();
    }

    public Articulo BuscarArticulo(string codigo)
    {
        return articulos.Find(a => a.Codigo == codigo);
    }

    public void ModificarArticulo(string codigo, string nuevoNombre, decimal nuevoPrecio, int nuevoStock)
    {
        var art = BuscarArticulo(codigo);
        if (art != null)
        {
            art.Nombre = nuevoNombre;
            art.Precio = nuevoPrecio;
            art.Stock = nuevoStock;
            Console.WriteLine("✅ Artículo modificado correctamente.");
        }
        else
        {
            Console.WriteLine("❌ Artículo no encontrado.");
        }
    }
}


