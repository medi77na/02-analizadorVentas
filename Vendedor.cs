public class Vendedor
{
    private Guid id { get; }
    private string nombre { get; set; }
    private string numeroTelefono { get; set;}

    public Vendedor(string nombre, string numeroTelefono)
    {
        id = Guid.NewGuid();
        this.nombre = nombre;
        this.numeroTelefono = numeroTelefono;
    }
}