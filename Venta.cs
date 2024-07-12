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
        this.fecha = definirFecha();
        this.cantidadProductos = cantidadProductos;
        this.vendedor = vendedor;
        this.comprador = comprador;
    }


    public DateTime definirFecha()
    {
        Random generadorAleatorio = new Random(); // Crea un generador de números aleatorios

        // Obtiene el año y mes actuales
        int añoActual = DateTime.Now.Year;
        int mesActual = DateTime.Now.Month;

        // Calcula el primer y último día del mes actual
        DateTime primerDiaMes = new DateTime(añoActual, mesActual, 1);
        DateTime ultimoDiaMes = primerDiaMes.AddDays(DateTime.DaysInMonth(añoActual, mesActual) - 1);

        // Calcula la diferencia en días entre el primer y último día del mes
        int rangoDias = 5;
        // (int)ultimoDiaMes.Subtract(primerDiaMes).TotalDays;

        // Genera un día aleatorio dentro del rango de la semana
        int diaAleatorioSemana = generadorAleatorio.Next(rangoDias + 1);

        // Crea la fecha aleatoria con los valores generados
        DateTime fechaAleatoria = primerDiaMes.AddDays(diaAleatorioSemana);
        
        return fechaAleatoria;
    }

}