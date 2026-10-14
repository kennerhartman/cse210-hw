class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello, Circle!");

        Circle circle = new Circle(4.1);

        Console.WriteLine(circle.GetRadius());
        Console.WriteLine(circle.GetCircumference());
        circle.SetRadius(1.3);
        Console.WriteLine(circle.GetRadius());
        Console.WriteLine(circle.GetArea());
    }
}