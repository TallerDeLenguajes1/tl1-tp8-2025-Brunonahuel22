using System.Dynamic;

namespace MundoTarea
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        private int duracion;

        public int Duracion
        {
            get { return duracion; }

            set
            {
                if (value >= 10 && value <= 100)
                {
                    duracion = value;
                }

                else
                {
                    Console.WriteLine("Ingrese un numero entre 10 y 100");
                }

            }



        }
        public Tarea(int tareaID, string descripcion, int duracion)
        {
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            this.Duracion = duracion; // Aquí se aplica la validación
        }

    }

    class MisFunciones
    {
        public void BuscarDescripcion(List<Tarea> Lista, string palabraABuscar)
        {

            foreach (var tarea in Lista)
            {
                if (tarea.Descripcion.Contains(palabraABuscar))
                {
                    Console.WriteLine("Palabra encontrada");
                }
            }
        }

        public static void MostrarTodasLasTareas(List<Tarea> pendientes, List<Tarea> realizadas)
        {
            Console.WriteLine("=== TAREAS PENDIENTES ===");
            foreach (var tarea in pendientes)
            {
                Console.WriteLine($"ID: {tarea.TareaID} | Descripción: {tarea.Descripcion} | Duración: {tarea.Duracion}");
            }

            Console.WriteLine();
            Console.WriteLine("=== TAREAS REALIZADAS ===");
            foreach (var tarea in realizadas)
            {
                Console.WriteLine($"ID: {tarea.TareaID} | Descripción: {tarea.Descripcion} | Duración: {tarea.Duracion}");
            }
        }

    }
}