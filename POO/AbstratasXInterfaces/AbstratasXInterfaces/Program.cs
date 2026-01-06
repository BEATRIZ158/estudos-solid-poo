namespace AbstratasXInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando a classe abstrata Figura
            var quadrado = new Quadrado("Quadrado");
            quadrado.Desenhar();
            quadrado.Identificar();
            Console.WriteLine();

            //Usando a interface IFigura
            var triangulo = new Triangulo("Triângulo");
            triangulo.Desenhar();
            triangulo.Identificar();
            triangulo.Duplicar();

            Console.ReadLine();
        }
    }
}