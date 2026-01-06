namespace ConsoleApp1
{
    class Escola : IDisposable
    {
        public string Nome { get; set; }
        private List<Departamento> departamentos =
            new List<Departamento>();

        private void AddDepartamento(string nome)
        {
            departamentos.Add(new Departamento(this, nome));
        }

        public void Dispose()
        {
            foreach(var departamento in departamentos)
            {
                departamento.Dispose();
            }
        }
    }
}
