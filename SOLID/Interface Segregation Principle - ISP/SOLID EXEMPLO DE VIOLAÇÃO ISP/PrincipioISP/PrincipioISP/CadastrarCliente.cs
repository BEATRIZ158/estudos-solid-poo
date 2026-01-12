namespace PrincipioISP
{
    class CadastrarCliente : IPersistencia, IMensagemEmail
    {
        public void ValidarDados()
        {
            Console.WriteLine("Valida Dados");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salva Dados");
        }

        public void EnviarEmail()
        {
            Console.WriteLine("Envia Email");
        }
    }
}
