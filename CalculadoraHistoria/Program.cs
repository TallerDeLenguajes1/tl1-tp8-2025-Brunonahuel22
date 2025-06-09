using Operaciones;

class Program
{
    static void Main(string[] args)
    {
        
        Calculadora miCalculadora = new Calculadora();

        // Realizar algunas operaciones
        miCalculadora.Sumar(10);
        miCalculadora.Restar(3);
        miCalculadora.Multiplicar(2);
        miCalculadora.Dividir(4);
        miCalculadora.Limpiar();

        // Mostrar resultado actual
        Console.WriteLine($"Resultado actual: {miCalculadora.Dato}");

        // Mostrar historial de operaciones
        Console.WriteLine("\nHistorial de operaciones:");

        foreach (var operacion in miCalculadora.ObtenerHistorial())
        {
            Console.WriteLine($"{operacion.operacion} - ResultadoAnterior: {operacion.resultadoAnterior} - NuevoValor: {operacion.NuevoValor} - Resultado: {operacion.Resultado}");
        }

        
    }
}
