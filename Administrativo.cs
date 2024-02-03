public class Administrativo : Empleado
{
    public string Departamento { get; set; }

    public void GestionarTramites()
    {
        Console.WriteLine($"El personal administrativo {Nombre} está gestionando trámites.");
    }

    public void AtenderAlPublico()
    {
        Console.WriteLine($"El personal administrativo {Nombre} está atendiendo al público.");
    }
}