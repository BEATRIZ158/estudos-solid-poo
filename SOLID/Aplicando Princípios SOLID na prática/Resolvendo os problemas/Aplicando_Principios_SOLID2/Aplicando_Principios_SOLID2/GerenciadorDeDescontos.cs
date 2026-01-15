namespace Aplicando_Principios_SOLID2
{
    class GerenciadorDeDescontos
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;
        public GerenciadorDeDescontos(ICalculaDescontoFidelidade _descontoFidelidade, ICalculaDescontoStatusContaFactory _descontoStatusConta)
        {
            descontoFidelidade = _descontoFidelidade;
            descontoStatusConta = _descontoStatusConta;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente,
            int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            
            precoDepoisDoDesconto = descontoStatusConta.GetCalculaDescontoStatusConta(statusContaCliente)
                .AplicarDescontoStatusConta(preco);

            precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
            
            return precoDepoisDoDesconto;
        }
    }
}
