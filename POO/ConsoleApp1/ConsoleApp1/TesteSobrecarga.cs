namespace ConsoleApp1
{
    class TesteSobrecarga
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }  

        public double Somar(double numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }

        public int Somar(params int[] numeros)
        {
            var resultado = 0;
            resultado += numeros.Sum();
            return resultado;
        }

        public void Executar()
        {
            var resultado1 = Somar(10, 20);
            var resultado2 = Somar(10.5, 20, 30);
            var resultado3 = Somar(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Resultado1: {resultado1}");
            Console.WriteLine($"Resultado2: {resultado2}");
            Console.WriteLine($"Resultado3: {resultado3}");
        }
    }
}
