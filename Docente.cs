public class Docente : Empleado
{
    public string AreaEspecialidad { get; set; }
    public string MateriasImpartidas { get; set; }

    public void PlanificarClases()
    {
        Console.WriteLine($"{Nombre} está planificando las clases para el próximo semestre.");
    }

    public void EvaluarEstudiantes()
    {
        Console.WriteLine($"{Nombre} está evaluando el desempeño de los estudiantes.");
    }
}