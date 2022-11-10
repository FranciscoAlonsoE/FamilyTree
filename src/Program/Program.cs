using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Antonio", 80);
            Persona p2 = new Persona("Francisco", 51);
            Persona p3 = new Persona("Juan", 50);
            Persona p4 = new Persona("Paula", 49);
            Persona p5 = new Persona("Lucia", 7);
            Persona p6 = new Persona("Pedro", 20);
            Persona p7 = new Persona("Alberto", 63);
            Persona p8 = new Persona("Luis", 60);
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
            BiggestSonvisitor visitor2 = new BiggestSonvisitor();
            LargestNameVisitor visitor3 = new LargestNameVisitor();
            n1.Accept(visitor);
            n1.Accept(visitor2);
            n1.Accept(visitor3);
            // visitar el árbol aquí
            Console.WriteLine($"La suma de las edades es: {visitor.TotalAge}.");
            Console.WriteLine($"El hijo mas grande es {visitor2.biggestSonName} y tiene {visitor2.biggestAge} años.");
            Console.WriteLine($"El nombre mas largo es: {visitor3.largestName}.");
        }
    }
}
