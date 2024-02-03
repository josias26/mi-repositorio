public class Exalumno : MiembroDeLaComunidad
{
    public string FechaGraduacion { get; set; }
    public string TituloObtenido { get; set; }

    public void SolicitarCertificado()
    {
        Console.WriteLine($"{Nombre} ha solicitado un certificado.");
    }

    public void Donar()
    {
        Console.WriteLine($"{Nombre} ha realizado una donación a la comunidad.");
    }
}