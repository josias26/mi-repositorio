public class Administrador : Docente
{
    public string NivelAcceso { get; set; }

    public void GestionarUsuarios()
    {
        Console.WriteLine($"El administrador {Nombre} está gestionando usuarios del sistema.");
    }

    public void ConfigurarSistema()
    {
        Console.WriteLine($"El administrador {Nombre} está configurando el sistema.");
    }
}