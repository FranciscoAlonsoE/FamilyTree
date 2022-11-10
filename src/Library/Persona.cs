namespace Library{
    public class Persona{
        private string nombre;
        private int edad;
        public string Nombre {
            get{
                return this.nombre;
            }
        }
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