using DIP;

var relationship = new Relationship();
var parent = new Person("A");
var child1 = new Person("A1");
var child2 = new Person("A2");

relationship.AddParentChild(parent, child1);
relationship.AddParentChild(parent, child2);
var research = new Research(relationship);