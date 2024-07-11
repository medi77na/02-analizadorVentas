public class Producto
{
    private int id { get; }
    private string nombre { get; set; }
    private double precio { get; set; }
    private int tiempoGarantia { get; set; }

    public Producto(int id, string nombre, double precio, int tiempoGarantia)
    {
        this.id = id;
        this.nombre = nombre;
        this.precio = precio;
        this.tiempoGarantia = tiempoGarantia;
    }
    
}