public class Cliente
{
    public string IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }

    public Cliente(string id, string nombre, string correo)
    {
        IdCliente = id;
        Nombre = nombre;
        Correo = correo;
    }

    public void MostrarCliente()
    {
        Console.WriteLine($"🧑 Cliente - ID: {IdCliente}, Nombre: {Nombre}, Correo: {Correo}");
    }
}


