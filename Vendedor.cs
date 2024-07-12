public class Vendedor
{
    public Guid id { get; }
    public string nombre { get; set; }
    public string numeroTelefono { get; set;}

    public Vendedor(string nombre, string numeroTelefono)
    {
        id = Guid.NewGuid();
        this.nombre = nombre;
        this.numeroTelefono = numeroTelefono;
    }


    
}