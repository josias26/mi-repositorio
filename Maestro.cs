public class Maestro : Docente
{
    public void ImpartirClase()
    {
        Console.WriteLine($"{Nombre} está impartiendo una clase a sus estudiantes.");
    }

    public void AsesorarEstudiantes()
    {
        Console.WriteLine($"{Nombre} está asesorando a sus estudiantes.");
    }
}