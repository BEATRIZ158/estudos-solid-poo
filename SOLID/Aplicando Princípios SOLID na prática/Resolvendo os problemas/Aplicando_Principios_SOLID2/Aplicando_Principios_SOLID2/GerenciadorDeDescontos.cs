namespace Aplicando_Principios_SOLID2
{
    public enum StatusContaCliente
    {
        NaoRegistrado = 1,
        ClienteComum = 2,
        ClienteEspecial = 3,
        ClienteVIP = 4
    }
    class GerenciadorDeDescontos
    {
        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente,
            int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > 5) ?
                (decimal)5 / 100 :
                (decimal)tempoDeContaEmAnos / 100;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoDepoisDoDesconto = preco;
                    break;
                case StatusContaCliente.ClienteComum:
                    precoDepoisDoDesconto = (preco - (0.1m * preco));
                    precoDepoisDoDesconto = precoDepoisDoDesconto -
                        (descontoPorFidelidade * precoDepoisDoDesconto);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoDepoisDoDesconto = (0.3m * preco);
                    precoDepoisDoDesconto = precoDepoisDoDesconto -
                        (descontoPorFidelidade * precoDepoisDoDesconto);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoDepoisDoDesconto = (preco - (0.5m * preco));
                    precoDepoisDoDesconto = precoDepoisDoDesconto -
                        (descontoPorFidelidade * precoDepoisDoDesconto);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return precoDepoisDoDesconto;
        }
    }
}
