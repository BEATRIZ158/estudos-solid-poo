namespace CursoFoop_Exercicio3
{
    internal interface ICalcularImpostoPais
    {
        decimal TotalRenda { get; set; }
        decimal TotalDeducao { get; set; }
        decimal CalcularValorImposto();
    }
}
