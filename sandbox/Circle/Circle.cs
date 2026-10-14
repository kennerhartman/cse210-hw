class Circle
{
    private double radius;
    private const double PI = 3.14159;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return (this.radius * this.radius) * PI;
    }

    public double GetCircumference()
    {
        return 2 * PI * this.radius;
    }

    public double GetRadius()
    {
        return this.radius;
    }

    public void SetRadius(double value)
    {
        if (value >= 0)
        {
            this.radius = value;
        }
    }
}