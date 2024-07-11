public class Vendedor
{
    private int id { get; }
    private string nombre { get; set; }
    private string numeroTelefono { get; set;}

    public Vendedor(int id, string nombre, string numeroTelefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.numeroTelefono = numeroTelefono;
    }
}