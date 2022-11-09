namespace Library{
    public class PersonAgeSumVisitor : Visitor{
        public int TotalAge;
        public override void Visit(Node node)
        {
            node.Person.Accept(this);
            foreach(Node nodeChildren in node.Children){
                nodeChildren.Accept(this);
            }
        }
        public override void Visit(Persona persona)
        {
            this.TotalAge += persona.Edad;
        }
    }
}