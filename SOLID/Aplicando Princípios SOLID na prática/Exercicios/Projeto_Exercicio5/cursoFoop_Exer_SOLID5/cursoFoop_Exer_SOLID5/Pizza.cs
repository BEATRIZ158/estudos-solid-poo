namespace cursoFoop_Exer_SOLID5
{
    public abstract class Pizza
    {
        protected Pizza(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public abstract int AssarPizza();
        public void DeliverarPizza()
        {
            Console.WriteLine($"A pizza {Nome} foi entregue.");
        }
    }
}
