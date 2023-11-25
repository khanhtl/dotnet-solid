namespace DIP
{
    internal class Research
    {
        IRelationshipBrowser _relationship;
        string _name;
        public Research(IRelationshipBrowser relationship, string name)
        {
            _relationship = relationship;
            _name = name;

        }
        public void PrintChildren()
        {
            foreach (var p in _relationship.FindAllChildrenOf(_name))
            {
                Console.WriteLine($"{_name} has a child: {p.Name}");
            }
        }
    }
}
