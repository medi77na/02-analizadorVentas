public class Ventas
{

    private Guid id { get;}
    private DateTime fecha { get; set;}
    private List<Dictionary<string,object>> cantidadProductos { get; set; }
    private Vendedor vendedor { get; set;}
    private Comprador comprador { get; set; }

    public Ventas(List<Dictionary<string, object>> cantidadProductos, Vendedor vendedor, Comprador comprador)
    {
        id = Guid.NewGuid();
        this.fecha = DateTime.Now;
        this.cantidadProductos = cantidadProductos;
        this.vendedor = vendedor;
        this.comprador = comprador;
    }    
} 