class Program
{
    public static void Main(string[] args)
    {


        Comprador primeroComprador = new Comprador("Valentina", "3226457283");
        Comprador segundoComprador = new Comprador("Carlos", "3115987462");
        Comprador terceroComprador = new Comprador("Laura", "3153245678");

        Vendedor primerVendedor = new Vendedor("Pedro", "3153247890");
        Vendedor segundoVendedor = new Vendedor("Maria", "3123456789");
        Vendedor tercerVendedor = new Vendedor("Juan", "3112345678");

        Producto primerProducto = new Producto("Mouse", 20.0, 15);
        Producto segundoProducto = new Producto("Teclado", 30.0, 30);
        Producto tercerProducto = new Producto("Monitor", 500.0, 45);
        Producto cuartoProducto = new Producto("Base", 10.0, 20);
        Producto quintoProducto = new Producto("Mousepad", 15.0, 10);



    }
}