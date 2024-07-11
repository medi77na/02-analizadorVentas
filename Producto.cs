public class Producto
{
    private Guid id { get; }
    private string nombre { get; set; }
    private double precio { get; set; }
    private int tiempoGarantia { get; set; }

    public Producto(string nombre, double precio, int tiempoGarantia)
    {
        id = Guid.NewGuid();
        this.nombre = nombre;
        this.precio = precio;
        this.tiempoGarantia = tiempoGarantia;
    }

 

    
}