namespace CursoFoop_Solid_Exercicio2
{
    class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"C:\Dados\Teste.txt", mensagem);
        }
    }
}
