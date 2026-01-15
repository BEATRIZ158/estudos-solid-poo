namespace Aplicando_Principios_SOLID2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaDescontoFidelidade descFide = new CalculaDescontoFidelidade();

            ICalculaDescontoStatusContaFactory descConta = new CalculaDescontoStatusContaFactory();

            GerenciadorDeDescontos gerenciadorDeDescontos = new GerenciadorDeDescontos(descFide, descConta);

            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

            var resultado1 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de: {resultado1}");

            var resultado2 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de: {resultado2}");

            var resultado3 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de: {resultado3}");

            Console.WriteLine("\n\nValor da compra 1000 e fidelidade 4 anos (4%)\n");

            var resultado4 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de: {resultado4}");

            var resultado5 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de: {resultado5}");

            var resultado6 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de: {resultado6}");

            Console.ReadLine();
        }
    }
}
