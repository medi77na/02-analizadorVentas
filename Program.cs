partial class Program
{
    public static void Main(string[] args)
    {

        List<Producto> listaProductos = new List<Producto>();
        List<Vendedor> listaVendedores = new List<Vendedor>();
        List<Comprador> listaCompradores = new List<Comprador>();
        List<Ventas> listaVentas = new List<Ventas>();

        void crearCompradores()
        {
            Comprador primeroComprador = new Comprador("Valentina", "3226457283");
            Comprador segundoComprador = new Comprador("Carlos", "3115987462");
            Comprador terceroComprador = new Comprador("Laura", "3153245678");

            listaCompradores.Add(primeroComprador);
            listaCompradores.Add(segundoComprador);
            listaCompradores.Add(terceroComprador);
        }

        void crearVendedor()
        {
            Vendedor primerVendedor = new Vendedor("Pedro", "3153247890");
            Vendedor segundoVendedor = new Vendedor("Maria", "3123456789");
            Vendedor tercerVendedor = new Vendedor("Juan", "3112345678");



            listaVendedores.Add(primerVendedor);
            listaVendedores.Add(segundoVendedor);
            listaVendedores.Add(tercerVendedor);
        }

        void crearProductos()
        {
            Producto primerProducto = new Producto("Mouse", 20.0, 15);
            Producto segundoProducto = new Producto("Teclado", 30.0, 30);
            Producto tercerProducto = new Producto("Monitor", 500.0, 45);
            Producto cuartoProducto = new Producto("Base", 10.0, 20);
            Producto quintoProducto = new Producto("Mousepad", 15.0, 10);

            listaProductos.Add(primerProducto);
            listaProductos.Add(segundoProducto);
            listaProductos.Add(tercerProducto);
            listaProductos.Add(cuartoProducto);
            listaProductos.Add(quintoProducto);

        }

        void crearFactura()
        {
            int opcion = 1;
            List<Dictionary<string, object>> listaProductoCantidad = new List<Dictionary<string, object>>();

            Console.WriteLine(@$"Registrar Venta: 
            -------------------------------------");
            listarCompradores();
            Console.WriteLine("Ingrese el número del comprador: ");
            int comprador = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Clear();

            listarVendedores();
            Console.WriteLine("Ingrese el número del vendedor: ");
            int vendedor = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Clear();

            do
            {
                switch (opcion)
                {
                    case 1:
                        listarProductos();
                        Console.Write("Ingrese el número del producto que desea comprar: ");
                        int producto = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.Write("Digite la cantidad que desea llevar: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        var diccionarioProductosVenta = new Dictionary<string, object>(){
                            { "producto", listaProductos[producto].nombre},
                            { "precio", listaProductos[producto].precio},
                            { "tiempoGarantia", listaProductos[producto].tiempoGarantia},
                            { "cantidad", cantidad}
                        };

                        listaProductoCantidad.Add(diccionarioProductosVenta);
                        Console.WriteLine("Producto registrado con éxito: ");
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(@"Desea agregar otro producto 
1- Si
2- No");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Se ha registrado la venta con éxito!");
                        opcion = 2;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta, intente nuevamente.");
                        Console.Clear();
                        break;
                }
            } while (opcion != 2);

            Ventas venta = new Ventas(listaProductoCantidad, listaVendedores[vendedor], listaCompradores[comprador]);
            listaVentas.Add(venta);
        }


        void listarProductos()
        {
            int i = 1;
            foreach (var producto in listaProductos)
            {
                Console.WriteLine(@$"Producto número {i}: 
Nombre: {producto.nombre} 
Precio: {producto.precio} 
Tiempo de garantia: {producto.tiempoGarantia} meses
-----------------------------");
                i++;
            }
        }

        void listarCompradores()
        {
            int i = 1;
            foreach (var comprador in listaCompradores)
            {
                Console.WriteLine(@$"Comprador número {i}: 
Nombre: {comprador.nombre} 
Telefono: {comprador.numeroTelefono}
-----------------------------");
                i++;
            }
        }

        void listarVendedores()
        {
            int i = 1;
            foreach (var vendedor in listaVendedores)
            {
                Console.WriteLine(@$"Vendedor número {i}: 
Nombre: {vendedor.nombre} 
Precio: {vendedor.numeroTelefono} 
-----------------------------");
                i++;
            }
        }

        void listarVentas()
        {
            int i = 1;
            foreach (var venta in listaVentas)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(@$"FACTURA NÚMERO #{i}
Id de la factura: {venta.id.ToString()}
Fecha de la venta: {venta.fecha.ToShortDateString()}
Vendedor: {venta.vendedor.nombre}
Comprador: {venta.comprador.nombre}");
                Console.WriteLine("Productos vendidos:");
                foreach (var producto in venta.cantidadProductos)
                {
                    Console.WriteLine($"Producto: {producto["producto"]}, Cantidad: {producto["cantidad"]}");
                }
            }
            Console.WriteLine("-----------------------------------");
            i++;
        }

        void mostrarMenu()
        {

            string? op = "0";

            do
            {
                Console.WriteLine(
$@"###############################################################################################
#                             SISTEMA DE ANALISIS DE VENTAS                                   #
###############################################################################################
1. Registrar nueva venta
2. Consultar valor total de una venta
3. Consultar promedio de ventas diarias
4. Ver empleado y cliente del mes
5. Filtrar ventas por fecha
6. Consultar vendedores por encima de un valor
7. Consultar total de ventas mensuales
8. Encontrar el mejor vendedor por periodo
9. Mostrar Top N Ventas por Valor Descendente
10. Mostrar productos mas vendidos por año
11. Consultar ventas por valor especifico
12. Consultar ventas por cliente
13. Mostrar total de ventas y promedio por vendedor
14. Ver mes con mayor numero de ventas y detalles
15. Salir
-----------------------------------------------------------------------------------------------
Selecciona una opcion --> ");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        crearFactura();
                        break;
                    case "2":
                        CalcularValorTotalVenta();
                        break;
                    case "3":
                        // CalcularPromedioDiarioVentas(sellSheet);
                        break;
                    case "4":
                        // MostrarEmpleadoYClienteDelMes(sellSheet);
                        break;
                    case "5":
                        // FiltrarVentasPorFecha(sellSheet);
                        break;
                    case "6":
                        // VendedoresPorEncimaDelValor(sellSheet);
                        break;
                    case "7":
                        // CalcularTotalVentasMensuales(sellSheet);
                        break;
                    case "8":
                        // EncontrarVendedorTopEnPeriodo(sellSheet);
                        break;
                    case "9":
                        // MostrarTopNVentasDescendente(sellSheet);
                        break;
                    case "10":
                        // MostrarProductosMejorVendidosPorAño(sellSheet);
                        break;
                    case "11":
                        // BuscarVentasPorValor(sellSheet);
                        break;
                    case "12":
                        // BuscarVentasPorCliente(sellSheet);
                        break;
                    case "13":
                        // MostrarVentasTotalesYPromedioPorVendedor(sellSheet);
                        break;
                    case "14":
                        // MostrarMesConMayoresVentas(sellSheet);
                        break;
                    case "15":
                        Console.WriteLine("Saliendo del programa...");
                        Console.WriteLine("Gracias por usar el gestor de ventas.");

                        break;

                }
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();


            } while (op != "15");
        }

        void CalcularValorTotalVenta()
        {

            double valorTotal = 0;
            Console.Clear();
            listarVentas();
            Console.Write("Ingrese el número de la factura que desea calcular: ");
            int numeroFactura = Convert.ToInt32(Console.ReadLine()) - 1;

            var facturaOperacion = listaVentas[numeroFactura];

            foreach (var producto in facturaOperacion.cantidadProductos)
            {
                valorTotal += Convert.ToDouble(producto["precio"]) * Convert.ToInt32(producto["cantidad"]);
            }
            Console.Clear();
            Console.WriteLine($"El valor total de la venta #{numeroFactura + 1} es: ${valorTotal}"); Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        crearCompradores();
        crearVendedor();
        crearProductos();
        mostrarMenu();
    }

}
