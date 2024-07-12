public class Comprador
{
    public Guid id { get; }
    public string nombre { get; set; }
    public string numeroTelefono { get; set; }

    public Comprador(string nombre, string numeroTelefono){
        id =  Guid.NewGuid();;
        this.nombre = nombre;
        this.numeroTelefono = numeroTelefono;
    }

}