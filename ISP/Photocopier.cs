namespace ISP
{
    internal class Photocopier : IPrinter, IScanner
    {
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
