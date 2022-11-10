using System;
namespace Library{
    public class BiggestSonvisitor : Visitor{
        public Node biggestSon;
        public int biggestAge = 0;
        public string biggestSonName = "";
        public bool isBigger=false;
        public override void Visit(Node node)
        {
            foreach(Node nodeChildren in node.Children){
                nodeChildren.persona.Accept(this);
                if(isBigger){
                    biggestSon = nodeChildren;
                }
                nodeChildren.Accept(this);
            }
        }
        public override void Visit(Persona persona)
        {
            if(persona.Edad > biggestAge){
                
                biggestAge = persona.Edad;
                biggestSonName = persona.Nombre;
                isBigger = true;
            }else{
                isBigger = false;
            }
        }
    }
}