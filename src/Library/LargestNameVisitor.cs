namespace Library{
    public class LargestNameVisitor : Visitor{
        public string largestName = "";
        public override void Visit(Node node)
        {
            node.Person.Accept(this);
            foreach(Node nodeChildren in node.Children){
                nodeChildren.Accept(this);
            }
        }
        public override void Visit(Persona persona)
        {
            if(persona.Nombre.Length > largestName.Length){
                largestName = persona.Nombre;
            };
        }
    }
}