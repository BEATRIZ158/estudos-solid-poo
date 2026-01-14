namespace Aplicando_Principios_SOLID2
{
    class GerenciadorDeDescontos
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        public GerenciadorDeDescontos(ICalculaDescontoFidelidade _descontoFidelidade)
        {
            descontoFidelidade = _descontoFidelidade;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente,
            int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoDepoisDoDesconto = preco;
                    break;
                case StatusContaCliente.ClienteComum:
                    precoDepoisDoDesconto = (preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco));
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoDepoisDoDesconto = (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco);
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoDepoisDoDesconto = (preco - (Constantes.DESCONTO_CLIENTE_VIP * preco));
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return precoDepoisDoDesconto;
        }
    }
}
