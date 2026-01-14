namespace Aplicando_Principios_SOLID2
{
    class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FEDELIDADE) ?
                (decimal)Constantes.DESCONTO_MAXIMO_POR_FEDELIDADE / 100 : (decimal)tempoDeContaEmAnos / 100;
            
            return preco - (preco * descontoPorFidelidade);
        }
    }
}
