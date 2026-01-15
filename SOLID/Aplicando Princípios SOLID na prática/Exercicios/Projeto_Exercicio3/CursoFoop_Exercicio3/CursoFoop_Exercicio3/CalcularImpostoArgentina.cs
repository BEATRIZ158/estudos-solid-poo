namespace CursoFoop_Exercicio3
{
    internal class CalcularImpostoArgentina : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorbase = TotalRenda - TotalDeducao;
            return valorbase * 40 / 100;
        }
    }
}
