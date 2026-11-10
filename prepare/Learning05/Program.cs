class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 2);
        Rectangle rectangle = new Rectangle("blue", 25, 8);
        Circle circle = new Circle("green", 3);
        
        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}; Area: {shape.GetArea()}");
        }
    }
}