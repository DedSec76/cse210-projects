using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(new Square("white", 4));
        shapes.Add(new Rectangle("blue", 4, 6));
        shapes.Add(new Circle("purple", 5));
        
        Console.Clear();
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()}\n");
        }
    }
}