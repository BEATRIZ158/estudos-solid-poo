namespace cursoFoop_Exer_SOLID5
{
    internal class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(string nome) : base(nome)
        { }

        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assando a pizza de {Nome} por {tempo} minutos.");
            return tempo;
        }
    }
}
