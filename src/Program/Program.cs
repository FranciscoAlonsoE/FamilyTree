using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Abuelo", 80);
            Persona p2 = new Persona("Hijo1", 51);
            Persona p3 = new Persona("Hijo2", 50);
            Persona p4 = new Persona("Hijo3", 49);
            Persona p5 = new Persona("Nieto1", 7);
            Persona p6 = new Persona("Nieto2", 20);
            Persona p7 = new Persona("Nieto3", 19);
            Persona p8 = new Persona("Nieto4", 17);
            Node n1 = new Node(p1);
            Node n2 = new Node(p2);
            Node n3 = new Node(p3);
            Node n4 = new Node(p4);
            Node n5 = new Node(p5);
            Node n6 = new Node(p6);
            Node n7 = new Node(p7);
            Node n8 = new Node(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);
            n2.AddChildren(n5);
            n2.AddChildren(n6);
            n3.AddChildren(n7);
            n4.AddChildren(n8);
            PersonAgeSumVisitor visitor = new PersonAgeSumVisitor();
            n1.Accept(visitor);
            // visitar el árbol aquí
            Console.WriteLine(visitor.TotalAge);
        }
    }
}
