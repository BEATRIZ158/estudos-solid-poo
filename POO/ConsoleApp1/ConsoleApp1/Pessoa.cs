namespace ConsoleApp1
{
    class Pessoa
    {
        //field
        public string nome;
        public int idade;
        public string genero;

        //Default Constructor - construtor padrão, sem parâmetros, que estava oculto
        public Pessoa()
        {
        }

        //Constructor - método especial que é executado quando a classe é instanciada
        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        //método executa uma ação, define um comportamento
        public void Identificar()
        {
            Console.WriteLine($"Olá, sou o {nome} tenho {idade} e sou do sexo {genero}!");
        }
    }
}