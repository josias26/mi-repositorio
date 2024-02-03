public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public string FechaNacimiento { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string CorreoElectronico { get; set; }

    public void registrarse()
    {
        Console.WriteLine($"{Nombre} se a registrado en la comunidad");
    }

    public void ActualizarInformacion()
    {
        Console.WriteLine($"{Nombre}: Información actualizada.");
    }

    public void ConsultarInformacion()
    {
        Console.WriteLine($"Información de {Nombre}:");
        Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine($"Teléfono: {Telefono}");
        Console.WriteLine($"Correo Electrónico: {CorreoElectronico}");
    }
}