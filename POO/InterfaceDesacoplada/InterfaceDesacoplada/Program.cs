using InterfaceDesacoplada;

class Program
{
    static void Main(string[] args)
    {
        var registraOcorrenciasNoConsole = new RegistraOcorrencias(new RegistrarNoConsole());
        registraOcorrenciasNoConsole.Registrar("Registro console");

        var registraOcorrenciasNoArquivo = new RegistraOcorrencias(new RegistrarNoArquivo(@"c:\Dados\Teste.txt"));
        registraOcorrenciasNoArquivo.Registrar("Registro arquivo");

        Console.ReadLine();
    }
}
