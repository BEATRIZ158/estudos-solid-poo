namespace ConsoleApp1
{
    class EstudandoThis
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        //Qualficar membros ocultados por nomes semelhantes
        //Usando o this para qualificar os membros da instância atual
        public EstudandoThis(string Nome, string Email)
        {
            //Use this para qualificar as propriedades
            //Nome e Email evitando confusão com os nomes
            //dos parâmetros usados no construtor
            //this se refere a instância atual da classe
            this.Nome = Nome;
            this.Email = Email;
        }
    }
}
