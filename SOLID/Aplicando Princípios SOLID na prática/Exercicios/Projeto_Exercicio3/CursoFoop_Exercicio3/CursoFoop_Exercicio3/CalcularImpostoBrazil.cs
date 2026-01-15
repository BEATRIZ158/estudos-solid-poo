namespace CursoFoop_Exercicio3
{
    internal class CalcularImpostoBrazil : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorbase = TotalRenda - TotalDeducao;
            return valorbase * 20 / 100;
        }
    }
}
