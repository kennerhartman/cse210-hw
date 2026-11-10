class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color) 
    {
        this._radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * (this._radius * this._radius);
    }
}