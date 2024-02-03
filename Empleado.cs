public class Empleado : MiembroDeLaComunidad
{
    public string FechaInicioLaboral { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }

    public void MarcarEntrada()
    {
        Console.WriteLine($"{Nombre} ha marcado su entrada al trabajo.");
    }

    public void MarcarSalida()
    {
        Console.WriteLine($"{Nombre} ha marcado su salida del trabajo.");
    }

    public void SolicitarVacaciones()
    {
        Console.WriteLine($"{Nombre} ha solicitado vacaciones.");
    }
}