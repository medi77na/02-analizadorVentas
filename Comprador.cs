public class Comprador
{
    private Guid id { get; }
    private string nombre { get; set; }
    private string numeroTelefono { get; set; }

    public Comprador(string nombre, string numeroTelefono){
        id =  Guid.NewGuid();;
        this.nombre = nombre;
        this.numeroTelefono = numeroTelefono;
    }

}