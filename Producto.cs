public class Producto
{
    public Guid id { get; }
    public string nombre { get; set; }
    public double precio { get; set; }
    public int tiempoGarantia { get; set; }

    public Producto(string nombre, double precio, int tiempoGarantia)
    {
        id = Guid.NewGuid();
        this.nombre = nombre;
        this.precio = precio;
        this.tiempoGarantia = tiempoGarantia;
    }    
}