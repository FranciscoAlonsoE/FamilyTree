namespace Library{
    public class Persona{
        private string nombre{get;set;}
        private int edad;
        public int Edad {
            get{
                return this.edad;
            }
        }

        public Persona(string nombre, int edad){
            this.nombre = nombre;
            this.edad = edad;
        }
        public void Accept(Visitor visitor){
            visitor.Visit(this);
        }
    }
}