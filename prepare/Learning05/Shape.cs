abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        this._color = color;
    }

    public string GetColor()
    {
        return this._color;
    }

    public void SetColor(string value)
    {
        this._color = value;
    }

    public abstract double GetArea();
}