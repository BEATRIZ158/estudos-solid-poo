namespace ConsoleApp1
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            DomainExceptionValidation.When(id < 0, "Id inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "Endereço inválido");

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
    }
}
