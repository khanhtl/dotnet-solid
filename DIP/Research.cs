namespace DIP
{
    internal class Research
    {
        public Research(Relationship relationship)
        {
            var _relations = relationship.relations;
            foreach (var r in _relations.Where(r => r.Item1.Name == "A" && r.Item2 == EnumRelationship.Parent))
            {
                Console.WriteLine($"A has a child: {r.Item3.Name}");
            }
        }
    }
}
