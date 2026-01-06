namespace AbstrataESelado
{
    class Y : X
    {
        sealed protected override void F()
        {
            Console.WriteLine("Y.F");
        }

        protected sealed override void F2()
        {
            Console.WriteLine("Y.F2");
        }
    }
}
