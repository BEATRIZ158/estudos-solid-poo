namespace AbstratasXInterfaces
{
    class Quadrado : Figura
    {
        public Quadrado(string nome) : base(nome)
        { }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando {Nome}");
            Duplicar(); //Aqui herdamos a propriedade Nome eo método Duplicar da classe abstrata Figura
        }

        public override void Identificar()
        {
            Console.WriteLine($"Esta figura é um {Nome}");
        }
    }
}
