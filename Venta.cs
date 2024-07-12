public class Ventas
{

    public Guid id { get; }
    public DateTime fecha { get; set; }
    public List<Dictionary<string, object>> cantidadProductos { get; set; }
    public Vendedor vendedor { get; set; }
    public Comprador comprador { get; set; }

    public Ventas(List<Dictionary<string, object>> cantidadProductos, Vendedor vendedor, Comprador comprador)
    {
        id = Guid.NewGuid();
        this.fecha = DateTime.Now;
        this.cantidadProductos = cantidadProductos;
        this.vendedor = vendedor;
        this.comprador = comprador;
    }


    public void calcularValorTotal(){
        
    }

}