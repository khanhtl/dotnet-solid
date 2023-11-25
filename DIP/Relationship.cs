namespace DIP
{
    internal class Relationship : IRelationshipBrowser
    {
        private List<(Person, EnumRelationship, Person)> _relations = new List<(Person, EnumRelationship, Person)>();
        public List<(Person, EnumRelationship, Person)> relations => _relations;

        public void AddParentChild(Person parent, Person child)
        {
            _relations.Add((parent, EnumRelationship.Parent, child));
            _relations.Add((child, EnumRelationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            var parentRelations = this._relations.Where(x => x.Item1.Name == name && x.Item2 == EnumRelationship.Parent);
            foreach (var r in parentRelations)
            {
                yield return r.Item3;
            }
        }

    }
}
