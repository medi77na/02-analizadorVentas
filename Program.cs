using System.Globalization;
using System.Runtime.CompilerServices;

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

        void ventasDefinidas()
        {
            List<Dictionary<string, object>> listaProductoCantidad = new List<Dictionary<string, object>>();

            var diccionarioProductosVenta = new Dictionary<string, object>(){
                { "producto", "Mouse"},
                { "precio", 20.0},
                { "tiempoGarantia", 15},
                { "cantidad", 5}
            };
            listaProductoCantidad.Add(diccionarioProductosVenta);

            Ventas venta = new Ventas(listaProductoCantidad, listaVendedores[0], listaCompradores[1]);
            listaVentas.Add(venta);


            List<Dictionary<string, object>> listaProductoCantidad2 = new List<Dictionary<string, object>>();
            var diccionarioProductosVenta2 = new Dictionary<string, object>(){
                { "producto", "Mouse"},
                { "precio", 20.0},
                { "tiempoGarantia", 15},
                { "cantidad", 2}
            };

            listaProductoCantidad2.Add(diccionarioProductosVenta2);

            Ventas venta2 = new Ventas(listaProductoCantidad2, listaVendedores[2], listaCompradores[0]);
            listaVentas.Add(venta2);


            List<Dictionary<string, object>> listaProductoCantidad3 = new List<Dictionary<string, object>>();
            var diccionarioProductosVenta3 = new Dictionary<string, object>(){
                { "producto", "Teclado"},
                { "precio", 30.0},
                { "tiempoGarantia", 30},
                { "cantidad", 3}
            };

            listaProductoCantidad3.Add(diccionarioProductosVenta3);

            Ventas venta3 = new Ventas(listaProductoCantidad3, listaVendedores[1], listaCompradores[2]);
            listaVentas.Add(venta3);


            List<Dictionary<string, object>> listaProductoCantidad4 = new List<Dictionary<string, object>>();
            var diccionarioProductosVenta4 = new Dictionary<string, object>(){
                { "producto", "Base"},
                { "precio", 10.0},
                { "tiempoGarantia", 20},
                { "cantidad", 10}
            };


            listaProductoCantidad4.Add(diccionarioProductosVenta4);

            Ventas venta4 = new Ventas(listaProductoCantidad4, listaVendedores[1], listaCompradores[1]);
            listaVentas.Add(venta4);


            List<Dictionary<string, object>> listaProductoCantidad5 = new List<Dictionary<string, object>>();
            var diccionarioProductosVenta5 = new Dictionary<string, object>(){
                { "producto", "Mouse"},
                { "precio", 20.0},
                { "tiempoGarantia", 15},
                { "cantidad", 5}
            };


            listaProductoCantidad5.Add(diccionarioProductosVenta5);

            Ventas venta5 = new Ventas(listaProductoCantidad5, listaVendedores[0], listaCompradores[1]);
            listaVentas.Add(venta5);


            List<Dictionary<string, object>> listaProductoCantidad6 = new List<Dictionary<string, object>>();
            var diccionarioProductosVenta6 = new Dictionary<string, object>(){
                { "producto", "Mouse"},
                { "precio", 20.0},
                { "tiempoGarantia", 15},
                { "cantidad", 5}
            };


            listaProductoCantidad6.Add(diccionarioProductosVenta6);

            Ventas venta6 = new Ventas(listaProductoCantidad6, listaVendedores[2], listaCompradores[0]);
            listaVentas.Add(venta6);

        };

        void crearVentas()
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
                i++;
            }
            Console.WriteLine("-----------------------------------");
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
                        crearVentas();
                        break;
                    case "2":
                        calcularValorTotalVenta();
                        break;
                    case "3":
                        calcularPromedioDiarioVentas();
                        break;
                    case "4":
                        mostrarEmpleadoYClienteDelMes();
                        break;
                    case "5":
                        filtrarVentasPorFecha();
                        break;
                    case "6":
                        vendedoresPorEncimaDelValor();
                        break;
                    case "7":
                        calcularTotalVentasMensuales();
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

        void calcularValorTotalVenta()
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

        void calcularPromedioDiarioVentas()
        {

            double valorTotal = 0;

            for (var i = 0; i < listaVentas.Count(); i++)
            {
                var venta = listaVentas[i];

                foreach (var diccionarioProductos in venta.cantidadProductos)
                {
                    valorTotal += Convert.ToDouble(diccionarioProductos["precio"]) * Convert.ToInt32(diccionarioProductos["cantidad"]);
                }
            }
            double promedioDiario = valorTotal / listaVentas.Count();
            Console.WriteLine($"El promedio de las ventas diarias es de ${Math.Round(promedioDiario, 2)}");
        };

        void mostrarEmpleadoYClienteDelMes()
        {

            double valorTotal = 0;
            var empleadoVentas = new List<double>();
            var clienteVentas = new List<double>();

            foreach (var vendedor in listaVendedores)
            {
                foreach (var venta in listaVentas)
                {
                    if (vendedor.nombre == venta.vendedor.nombre)
                    {
                        foreach (var producto in venta.cantidadProductos)
                        {
                            valorTotal += Convert.ToDouble(producto["precio"]) * Convert.ToInt32(producto["cantidad"]);
                        }
                    }
                }
                empleadoVentas.Add(valorTotal);
                valorTotal = 0;
            }
            var indiceEmpleadoMaximo = empleadoVentas.IndexOf(empleadoVentas.Max());
            var valorMaximo = empleadoVentas.Max();

            foreach (var comprador in listaCompradores)
            {
                foreach (var venta in listaVentas)
                {
                    if (comprador.nombre == venta.comprador.nombre)
                    {
                        foreach (var producto in venta.cantidadProductos)
                        {
                            valorTotal += Convert.ToDouble(producto["precio"]) * Convert.ToInt32(producto["cantidad"]);
                        }
                    }
                }
                clienteVentas.Add(valorTotal);
                valorTotal = 0;
            }
            var indiceCompradorMaximo = clienteVentas.IndexOf(clienteVentas.Max());
            var valorMaximoCliente = clienteVentas.Max();

            Console.WriteLine(@$"El comprador que más compró en el mes es: {listaCompradores[indiceCompradorMaximo].nombre} con valor de ${valorMaximoCliente}");
            Console.WriteLine(@$"El empleado que más vendió en el mes es: {listaVendedores[indiceEmpleadoMaximo].nombre} con valor de ${valorMaximo}");
        };

        void filtrarVentasPorFecha()
        {
            // Solicita la fecha al usuario
            Console.WriteLine("Ingrese una fecha (formato dd/MM/yyyy): ");
            string fechaString = Console.ReadLine();

            // Convierte la cadena de fecha a un objeto DateTime
            DateTime fechaUsuario = DateTime.ParseExact(fechaString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Filtra las ventas por la fecha
            var ventasFiltradas = listaVentas.Where(v => v.fecha.Date > fechaUsuario.Date).ToList();

            // Imprime las ventas filtradas
            Console.WriteLine("Ventas filtradas por fecha:");
            Console.WriteLine("-----------------------------------");
            foreach (var venta in ventasFiltradas)
            {
                Console.WriteLine($"Fecha: {venta.fecha.ToShortDateString()}, Vendedor: {venta.vendedor.nombre}, Comprador: {venta.comprador.nombre}");
            }
        }

        void vendedoresPorEncimaDelValor()
        {
            // Solicita el valor al usuario
            Console.WriteLine("Ingrese el valor para filtrar los vendedores:");
            double valorUsuario = Convert.ToDouble(Console.ReadLine());


            double valorTotal = 0;

            foreach (var vendedor in listaVendedores)
            {
                foreach (var venta in listaVentas)
                {
                    if (vendedor.nombre == venta.vendedor.nombre)
                    {
                        foreach (var producto in venta.cantidadProductos)
                        {
                            valorTotal += Convert.ToDouble(producto["precio"]) * Convert.ToInt32(producto["cantidad"]);
                        }
                    }
                }
                if (valorTotal > valorUsuario)
                {
                    Console.WriteLine($"El vendedor que supera los ${valorUsuario} es {vendedor.nombre}");
                }
                valorTotal = 0;
            }
        };

        void calcularTotalVentasMensuales()
        {

            //Agrupar las ventas por mes y calcular el total de ventas mensuales.

            var ventasPorMes = listaVentas.Select(v => v.fecha.Month).ToList();
            var ventaTotalMes = ventasPorMes.Count();

            Console.WriteLine($"El total de ventas por mes es: {ventaTotalMes}");
        };

        void encontrarVendedorTopEnPeriodo() 
        {

            //Encontrar el vendedor con el mayor número de ventas en un período específico.
            // Solicita la fecha al usuario
            Console.WriteLine("Ingrese una fecha (formato dd/MM/yyyy): ");
            string fechaString = Console.ReadLine();

            // Convierte la cadena de fecha a un objeto DateTime
            DateTime fechaUsuario = DateTime.ParseExact(fechaString, "dd/MM/yyyy", CultureInfo.InvariantCulture);


        };


        crearCompradores();
        crearVendedor();
        crearProductos();
        ventasDefinidas();
        mostrarMenu();
    }

}
