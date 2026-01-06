namespace InterfaceDesacoplada
{
    class RegistrarNoConsole : IRegistro
    {
        public RegistrarNoConsole()
        {
            
        }

        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"info : {mensagem}");
        }
    }
}
