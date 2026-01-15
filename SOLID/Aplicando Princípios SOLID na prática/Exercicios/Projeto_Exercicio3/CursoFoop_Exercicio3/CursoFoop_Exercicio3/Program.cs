using System;

namespace CursoFoop_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalcularImpostoPais calc = new CalcularImpostoBrazil();
            calc.TotalRenda = 1000;
            calc.TotalDeducao = 100;

            CalcularImposto calcularImp = new CalcularImposto();
            var valorTotalImposto = calcularImp.Calcular(calc);

            Console.ReadLine();
        }
    }
}
