namespace ISP
{
    internal class OldPrinter : IMachine
    {
        public void Fax(Document d)
        {
            Console.WriteLine($"Print: {d}");
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
