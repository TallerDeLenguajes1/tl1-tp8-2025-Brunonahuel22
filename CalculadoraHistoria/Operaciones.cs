namespace Operaciones
{

   
        class Calculadora
        {
            private double _dato;
            private List<Operacion> historial;

            public double Dato
            {
                get => _dato;
                set => _dato = value;
            }


            public Calculadora(int valorInicial = 0)
            {
                _dato = valorInicial;
                historial = new List<Operacion>();
            }

            public void Sumar(int parametro_sumar)
            {
                var operacion = new Operacion(_dato, parametro_sumar, TipoOperacion.Suma);
                _dato = operacion.Resultado;
                historial.Add(operacion);
            }
            public void Restar(int parametro_restar)
            {
                var operacion = new Operacion(_dato, parametro_restar, TipoOperacion.Resta);
                _dato = operacion.Resultado;
                historial.Add(operacion);
            }
            public void Multiplicar(int parametro_multiplicar)
            {
                var operacion = new Operacion(_dato, parametro_multiplicar, TipoOperacion.Multiplicacion);
                _dato = operacion.Resultado;
                historial.Add(operacion);
            }

            public void Dividir(int divisor)
            {
                if (divisor != 0)
                {
                    var operacion = new Operacion(_dato, divisor, TipoOperacion.Division);
                    _dato = (int)operacion.Resultado;
                    historial.Add(operacion);
                }
                else
                {
                    Console.WriteLine("¡Error! No se puede dividir por cero.");
                }
            }

            public void MostrarDatos()
            {
                Console.WriteLine(_dato);
            }
            public void Limpiar()
            {
                var operacion = new Operacion(_dato, 0, TipoOperacion.Limpiar);
                _dato = 0;
                historial.Add(operacion);
            }
            public List<Operacion> ObtenerHistorial()
            {
                return historial;
            }


        }
    






    public class Operacion
    {
        public double resultadoAnterior { get; } // Almacena el resultado previo al cálculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        public TipoOperacion operacion  { get; }// El tipo de operación realizada
        public double Resultado
        {
            get
            {
                switch (operacion)
                {
                    case TipoOperacion.Suma:
                        return resultadoAnterior + nuevoValor;
                    case TipoOperacion.Resta:
                        return resultadoAnterior - nuevoValor;
                    case TipoOperacion.Multiplicacion:
                        return resultadoAnterior * nuevoValor;
                    case TipoOperacion.Division:
                        return nuevoValor != 0 ? resultadoAnterior / nuevoValor : 0; // evitar división por 0
                    case TipoOperacion.Limpiar:
                        return 0; // para limpiar, devolvemos 0
                    default:
                        return resultadoAnterior;
                }
            }

        }

        // Propiedad pública para acceder al nuevo valor utilizado en la operación
        public double NuevoValor
        {
            get { return nuevoValor; }
        }



        // Constructor u otros métodos necesarios para inicializar y gestionar la operación
        // ...
        public Operacion(double PresultadoAnteroir, int parametro_nuevo_valor, TipoOperacion Parametro_operacion)
        {
            this.resultadoAnterior = PresultadoAnteroir;
            this.nuevoValor = parametro_nuevo_valor;
            this.operacion = Parametro_operacion;

        }

    }













    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar // Representa la acción de borrar el resultado actual o el historial
    }

}