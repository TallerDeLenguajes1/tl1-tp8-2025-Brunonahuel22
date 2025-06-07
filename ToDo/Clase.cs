using System.Dynamic;

namespace Clase
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
                // Opcional: agregar un else para avisar si es inválido
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Duracion), "La duración debe estar entre 10 y 100.");
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
}