namespace ISP
{
    internal class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            Console.WriteLine($"Fax: {d}");
        }

        public void Print(Document d)
        {
            Console.WriteLine($"Print: {d}");
        }

        public void Scan(Document d)
        {
            Console.WriteLine($"Scan: {d}");
        }
    }
}
