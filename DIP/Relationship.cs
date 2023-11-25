namespace DIP
{
    internal class Relationship
    {
        private List<(Person, EnumRelationship, Person)> _relations = new List<(Person, EnumRelationship, Person)>();
        public void AddParentChild(Person parent, Person child)
        {
            _relations.Add((parent, EnumRelationship.Parent, child));
            _relations.Add((child, EnumRelationship.Child, parent));
        }
        public List<(Person, EnumRelationship, Person)> relations => _relations;
    }
}
