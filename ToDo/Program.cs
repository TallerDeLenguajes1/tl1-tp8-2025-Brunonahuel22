using MundoTarea;
Random rand = new Random();

List<Tarea> TareasPendientes = new List<Tarea>();

int Ntareas = 5;

for (int i = 0; i < Ntareas; i++)
{
    Tarea Nuevatarea = new Tarea(i, $"Tarea {i}", rand.Next(10, 101));

    TareasPendientes.Add(Nuevatarea);


}

/*
Console.WriteLine("\tLista de tareas pendientes");
foreach (var tarea in TareasPendientes)
{
    Console.WriteLine($"Id:{tarea.TareaID}, Descripcion: {tarea.Descripcion}, Duracion:{tarea.Duracion}");
}
*/
 // Punto 3
List<Tarea> TareasRealizadas = new List<Tarea>();
int opcion;
Console.WriteLine("Quiere mover las tareas pendientes a realizadas?");
Console.WriteLine("1 = Sí, 0 = No");

string entrada = Console.ReadLine();
opcion = int.Parse(entrada);

if (opcion == 1)
{
    foreach (var TareaPendiente in TareasPendientes)
    {
        TareasRealizadas.Add(TareaPendiente);
    }
}

foreach (var tareaLista in TareasRealizadas)
{
    Console.WriteLine(tareaLista.Descripcion);
    Console.WriteLine();
}


// punto 4 

MisFunciones funcion = new MisFunciones();
funcion.BuscarDescripcion(TareasRealizadas,"Tarea 2");



