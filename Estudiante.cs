public class Estudiante : MiembroDeLaComunidad
{
    public string Matricula { get; set; }
    public string Carrera { get; set; }
    public double Promedio { get; set; }
    public string FechaInicioEstudios { get; set; }
    public string FechaFinEstudios { get; set; }

    public void Inscribirse()
    {
        Console.WriteLine($"{Nombre} se ha inscrito en nuevas materias.");
    }

    public void CursarMaterias()
    {
        Console.WriteLine($"{Nombre} está cursando materias en la carrera de {Carrera}.");
    }

    public void Graduarse()
    {
        Console.WriteLine($"{Nombre} ha completado sus estudios y se ha graduado.");
    }
}