namespace InterfaceDesacoplada
{
    class RegistrarNoArquivo : IRegistro
    {
        private readonly string _caminhoNomeArquivo;
        public RegistrarNoArquivo(string path)
        {
            _caminhoNomeArquivo = path;
        }

        public void RegistraInfo(string mensagem)
        {
            Log(mensagem);
        }

        private void Log(string mensagem)
        {
            using (var escritor = new StreamWriter(_caminhoNomeArquivo, true))
            {
                escritor.WriteLine($"{mensagem}");
            }
        }
    }
}
